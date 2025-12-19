using DVLD.Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.UI.User
{
    public partial class frmChangePassword: Form
    {
        private int _UserID;

        private clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            textCurrentPassword.Text = "";
            textNewPassword.Text = "";
            textConfirmPassword.Text = "";
            textCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = textNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Error Occurred, Password did not change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textCurrentPassword, "Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(textCurrentPassword, null);
            }


            if (_User.Password != textCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(textCurrentPassword, "Current Password is wrong!");

            }
            else
            {
                errorProvider1.SetError(textCurrentPassword, null);
            }

        }

        private void textConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textConfirmPassword.Text.Trim() != textNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(textConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(textConfirmPassword, null);
            }
        }

        private void textNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNewPassword, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(textNewPassword, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
