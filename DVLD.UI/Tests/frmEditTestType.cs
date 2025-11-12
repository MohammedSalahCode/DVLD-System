using DVLD.Business;
using DVLD.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.UI.Tests
{
    public partial class frmEditTestType: Form
    {
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;

        public frmEditTestType(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType != null)
            {
                lblTestTypeID.Text = ((int)_TestTypeID).ToString();
                textTitle.Text = _TestType.Title;
                textDescription.Text = _TestType.Description;
                textFees.Text = _TestType.Fees.ToString();
            }
            else
            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType.Title = textTitle.Text.Trim();
            _TestType.Description = textDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(textFees.Text.Trim());

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(textTitle, null);
            }
        }

        private void textDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textDescription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(textDescription, null);
            }
        }

        private void textFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(textFees, null);
            }

            if (!clsValidation.IsNumber(textFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(textFees, null);
            }
        }
    }
}
