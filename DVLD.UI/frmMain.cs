using System;
using System.Windows.Forms;
using DVLD.Classes;
using DVLD.UI.Tests;
using DVLD.UI.User;
using DVLD.UI.Applications;
using DVLD.UI.Drivers;
using DVLD.UI.Applications.InternationalLicense;
using DVLD.UI.Applications.RenewLocalLicense;
using DVLD.UI.Applications.ReplaceLostOrDamagedLicense;
using DVLD.UI.Licenses.DetainLicense;
using DVLD.UI.Applications.RleaseDetainedLicense;


namespace DVLD.UI
{
    public partial class frmMain: Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcomeUserLine1.Text = "Welcome, " + clsGlobal.CurrentUser.UserName + "!";    
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            pnlApplicationsSubMenu.Visible = !pnlApplicationsSubMenu.Visible;

            btnApplications.Text = btnApplications.Text.EndsWith("▸")
                ? btnApplications.Text.Replace("▸", "▾")
                : btnApplications.Text.Replace("▾", "▸");
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsers();
            frm.ShowDialog();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            pnlAccountSettingsSubMenu.Visible = !pnlAccountSettingsSubMenu.Visible;

            btnAccountSettings.Text = btnAccountSettings.Text.EndsWith("▸")
                ? btnAccountSettings.Text.Replace("▸", "▾")
                : btnAccountSettings.Text.Replace("▾", "▸");
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void btnDrivingLicenseServices_Click(object sender, EventArgs e)
        {
            pnlDrivingLicenseServicesSubMenu.Visible = !pnlDrivingLicenseServicesSubMenu.Visible;

            btnDrivingLicenseServices.Text = btnDrivingLicenseServices.Text.EndsWith("▸")
                ? btnDrivingLicenseServices.Text.Replace("▸", "▾")
                : btnDrivingLicenseServices.Text.Replace("▾", "▸");
        }

        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
            pnlNewDrivingLicenseSubMenu.Visible = !pnlNewDrivingLicenseSubMenu.Visible;

            btnNewDrivingLicense.Text = btnNewDrivingLicense.Text.EndsWith("▸")
                ? btnNewDrivingLicense.Text.Replace("▸", "▾")
                : btnNewDrivingLicense.Text.Replace("▾", "▸");
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            pnlManageApplicationsSubMenu.Visible = !pnlManageApplicationsSubMenu.Visible;

            btnManageApplications.Text = btnManageApplications.Text.EndsWith("▸")
                ? btnManageApplications.Text.Replace("▸", "▾")
                : btnManageApplications.Text.Replace("▾", "▸");
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            pnlDetainLicensesSubMenu.Visible = !pnlDetainLicensesSubMenu.Visible;

            btnDetainLicenses.Text = btnDetainLicenses.Text.EndsWith("▸")
                ? btnDetainLicenses.Text.Replace("▸", "▾")
                : btnDetainLicenses.Text.Replace("▾", "▸");
        }

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnInternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void btnLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void btnInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            frm.ShowDialog();
        }

        private void btnManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }
    }
}
