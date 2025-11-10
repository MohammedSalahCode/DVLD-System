using DVLD.Business;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.ApplicationTypes
{
    public partial class frmEditApplicationType: Form
    {
        private int _ApplicationTypeID = -1;

        private clsApplicationType _ApplicationType;

        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();

            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                textTitle.Text = _ApplicationType.Title;
                textFees.Text = _ApplicationType.Fees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplicationType.Title = textTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToSingle(textFees.Text.Trim());


            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
