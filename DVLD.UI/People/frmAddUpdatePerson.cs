using DVLD.Business;
using DVLD.Classes;
using DVLD.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.UI.frmAddUpdatePerson;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.UI
{
    public partial class frmAddUpdatePerson: Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            // Default image based on gender
            pbPersonImage.Image = rbMale.Checked ? Resources.Male_512 : Resources.Female_512;

            // Show/hide remove link
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            // Set valid date range (18–100 years)
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            // Default country
            cbCountry.SelectedIndex = cbCountry.FindString("Sudan");

            // Clear fields
            textFirstName.Text = "";
            textSecondName.Text = "";
            textThirdName.Text = "";
            textLastName.Text = "";
            textNationalNo.Text = "";
            rbMale.Checked = true;
            textPhone.Text = "";
            textEmail.Text = "";
            textAddress.Text = "";
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            // Fill form fields if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            textFirstName.Text = _Person.FirstName;
            textSecondName.Text = _Person.SecondName;
            textThirdName.Text = _Person.ThirdName;
            textLastName.Text = _Person.LastName;
            textNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            // Set gender
            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            // Contact info
            textAddress.Text = _Person.Address;
            textPhone.Text = _Person.Phone;
            textEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

            // Load image if available
            if (_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath;

            // Show/hide remove link
            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void frmAddEditPeople_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;


            int NationalityCountryID = clsCountry.Find(cbCountry.Text).ID;

            _Person.FirstName = textFirstName.Text;
            _Person.SecondName = textSecondName.Text;
            _Person.ThirdName = textThirdName.Text;
            _Person.LastName = textLastName.Text;
            _Person.NationalNo = textNationalNo.Text;
            _Person.Email = textEmail.Text;
            _Person.Phone = textPhone.Text;
            _Person.Address = textAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.NationalityCountryID = NationalityCountryID;


            if (rbMale.Checked)
                _Person.Gender = (short)enGendor.Male;
            else
                _Person.Gender = (short)enGendor.Female;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gender_Selected(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation != null)
                return;

            var rb = (RadioButton)sender;

            switch (rb.Tag)
            {
                case "0": // Male
                    pbPersonImage.Image = Resources.Male_512;
                    break;
                case "1": // Female
                    pbPersonImage.Image = Resources.Female_512;
                    break;
            }
        }

        private bool _HandlePersonImage()
        {
            // Handle image update: delete old image if changed, then copy and rename new one

            // Check if the image has changed
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                // Delete the old image if it exists
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // Could not delete the file (log later)  
                    }
                }

                // Copy new image to the project folder after renaming it
                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error copying image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }
            }

            return true;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true;
            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;


            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;


            llRemoveImage.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }

        }

        private void textNationalNO_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(textNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (textNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(textNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNationalNo, "National Number is used for another person!");
                textNationalNo.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(textNationalNo, null);
                textNationalNo.BackColor = Color.White;
            }

        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(textEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(textEmail, null);
            }
        }
    }
}
