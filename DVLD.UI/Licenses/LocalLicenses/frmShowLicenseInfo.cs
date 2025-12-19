using System;
using System.Windows.Forms;

namespace DVLD.UI.Licenses.LocalLicenses
{
    public partial class frmShowLicenseInfo: Form
    {
        private int _LicenseID;

        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.LoadInfo(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
