using System;
using System.ComponentModel;
using System.Windows.Forms;
using DVLD.Business;

namespace DVLD.UI.Licenses
{
    public partial class ctrlDriverLicenseInfoWithFilter: UserControl
    {
        // Event using a delegate with parameters, triggered when a license is selected (returns the LicenseID)
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlDriverLicenseInfo1.SelectedLicenseInfo; }
        }


        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            textLicenseID.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLicenseID.Focus();
                return;
            }

            _LicenseID = int.Parse(textLicenseID.Text);

            LoadLicenseInfo(_LicenseID);
        }

        public void txtLicenseIDFocus()
        {
            textLicenseID.Focus();
        }

        private void textLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
        }

        private void textLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textLicenseID, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(textLicenseID, null);
            }
        }
    }
}
