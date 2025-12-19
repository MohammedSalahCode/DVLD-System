using System.Drawing;

namespace DVLD.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeUserLine1 = new System.Windows.Forms.Label();
            this.lblWelcomeUserLine2 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlAccountSettingsSubMenu = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCurrentUserInfo = new System.Windows.Forms.Button();
            this.pnlAccountSettings = new System.Windows.Forms.Panel();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.pnlSpacer4 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlSpacer3 = new System.Windows.Forms.Panel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.pnlSpacer2 = new System.Windows.Forms.Panel();
            this.btnPeople = new System.Windows.Forms.Button();
            this.pnlSpacer1 = new System.Windows.Forms.Panel();
            this.pnlApplicationsSubMenu = new System.Windows.Forms.Panel();
            this.btnManageTestTypes = new System.Windows.Forms.Button();
            this.btnManageApplicationTypes = new System.Windows.Forms.Button();
            this.pnlDetainLicensesSubMenu = new System.Windows.Forms.Panel();
            this.btnReleaseDetainedLicense = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnManageDetainedLicenses = new System.Windows.Forms.Button();
            this.btnDetainLicenses = new System.Windows.Forms.Button();
            this.pnlManageApplicationsSubMenu = new System.Windows.Forms.Panel();
            this.btnInternationalLicenseApplications = new System.Windows.Forms.Button();
            this.btnLocalDrivingLicenseApplications = new System.Windows.Forms.Button();
            this.btnManageApplications = new System.Windows.Forms.Button();
            this.pnlDrivingLicenseServicesSubMenu = new System.Windows.Forms.Panel();
            this.btnRetakeTest = new System.Windows.Forms.Button();
            this.btnReplacement = new System.Windows.Forms.Button();
            this.btnRenewLicense = new System.Windows.Forms.Button();
            this.pnlNewDrivingLicenseSubMenu = new System.Windows.Forms.Panel();
            this.btnInternationalLicense = new System.Windows.Forms.Button();
            this.btnLocalLicense = new System.Windows.Forms.Button();
            this.btnNewDrivingLicense = new System.Windows.Forms.Button();
            this.btnDrivingLicenseServices = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.pnlTopSpacer = new System.Windows.Forms.Panel();
            this.pnlSidebar2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlAccountSettingsSubMenu.SuspendLayout();
            this.pnlAccountSettings.SuspendLayout();
            this.pnlApplicationsSubMenu.SuspendLayout();
            this.pnlDetainLicensesSubMenu.SuspendLayout();
            this.pnlManageApplicationsSubMenu.SuspendLayout();
            this.pnlDrivingLicenseServicesSubMenu.SuspendLayout();
            this.pnlNewDrivingLicenseSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeUserLine1
            // 
            this.lblWelcomeUserLine1.AutoSize = true;
            this.lblWelcomeUserLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblWelcomeUserLine1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUserLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblWelcomeUserLine1.Location = new System.Drawing.Point(303, 34);
            this.lblWelcomeUserLine1.Name = "lblWelcomeUserLine1";
            this.lblWelcomeUserLine1.Size = new System.Drawing.Size(146, 25);
            this.lblWelcomeUserLine1.TabIndex = 1;
            this.lblWelcomeUserLine1.Text = "Welcome, User!";
            // 
            // lblWelcomeUserLine2
            // 
            this.lblWelcomeUserLine2.AutoSize = true;
            this.lblWelcomeUserLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblWelcomeUserLine2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUserLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblWelcomeUserLine2.Location = new System.Drawing.Point(304, 64);
            this.lblWelcomeUserLine2.Name = "lblWelcomeUserLine2";
            this.lblWelcomeUserLine2.Size = new System.Drawing.Size(123, 21);
            this.lblWelcomeUserLine2.TabIndex = 4;
            this.lblWelcomeUserLine2.Text = "to DVLD System";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.pnlSidebar.Controls.Add(this.pnlAccountSettingsSubMenu);
            this.pnlSidebar.Controls.Add(this.pnlAccountSettings);
            this.pnlSidebar.Controls.Add(this.pnlSpacer4);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.pnlSpacer3);
            this.pnlSidebar.Controls.Add(this.btnDrivers);
            this.pnlSidebar.Controls.Add(this.pnlSpacer2);
            this.pnlSidebar.Controls.Add(this.btnPeople);
            this.pnlSidebar.Controls.Add(this.pnlSpacer1);
            this.pnlSidebar.Controls.Add(this.pnlApplicationsSubMenu);
            this.pnlSidebar.Controls.Add(this.btnApplications);
            this.pnlSidebar.Controls.Add(this.pnlTopSpacer);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(25, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 912);
            this.pnlSidebar.TabIndex = 6;
            // 
            // pnlAccountSettingsSubMenu
            // 
            this.pnlAccountSettingsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlAccountSettingsSubMenu.Controls.Add(this.btnSignOut);
            this.pnlAccountSettingsSubMenu.Controls.Add(this.btnChangePassword);
            this.pnlAccountSettingsSubMenu.Controls.Add(this.btnCurrentUserInfo);
            this.pnlAccountSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountSettingsSubMenu.Location = new System.Drawing.Point(0, 810);
            this.pnlAccountSettingsSubMenu.Name = "pnlAccountSettingsSubMenu";
            this.pnlAccountSettingsSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlAccountSettingsSubMenu.TabIndex = 10;
            this.pnlAccountSettingsSubMenu.Visible = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 60);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(220, 30);
            this.btnSignOut.TabIndex = 17;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 30);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(220, 30);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentUserInfo.FlatAppearance.BorderSize = 0;
            this.btnCurrentUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnCurrentUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(220, 30);
            this.btnCurrentUserInfo.TabIndex = 15;
            this.btnCurrentUserInfo.Text = "Current User Info";
            this.btnCurrentUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentUserInfo.UseVisualStyleBackColor = false;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // pnlAccountSettings
            // 
            this.pnlAccountSettings.Controls.Add(this.btnAccountSettings);
            this.pnlAccountSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAccountSettings.Location = new System.Drawing.Point(0, 760);
            this.pnlAccountSettings.Name = "pnlAccountSettings";
            this.pnlAccountSettings.Size = new System.Drawing.Size(220, 50);
            this.pnlAccountSettings.TabIndex = 19;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAccountSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.btnAccountSettings.Image = global::DVLD.UI.Properties.Resources.settings_24;
            this.btnAccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettings.Location = new System.Drawing.Point(0, 0);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(220, 50);
            this.btnAccountSettings.TabIndex = 15;
            this.btnAccountSettings.Text = "        Account Settings ▸";
            this.btnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // pnlSpacer4
            // 
            this.pnlSpacer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer4.Enabled = false;
            this.pnlSpacer4.Location = new System.Drawing.Point(0, 750);
            this.pnlSpacer4.Name = "pnlSpacer4";
            this.pnlSpacer4.Size = new System.Drawing.Size(220, 10);
            this.pnlSpacer4.TabIndex = 18;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.btnUsers.Image = global::DVLD.UI.Properties.Resources.users_24;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 700);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(220, 50);
            this.btnUsers.TabIndex = 14;
            this.btnUsers.Text = "        Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlSpacer3
            // 
            this.pnlSpacer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer3.Enabled = false;
            this.pnlSpacer3.Location = new System.Drawing.Point(0, 690);
            this.pnlSpacer3.Name = "pnlSpacer3";
            this.pnlSpacer3.Size = new System.Drawing.Size(220, 10);
            this.pnlSpacer3.TabIndex = 17;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.btnDrivers.Image = global::DVLD.UI.Properties.Resources.drivers_24;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.Location = new System.Drawing.Point(0, 640);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(220, 50);
            this.btnDrivers.TabIndex = 12;
            this.btnDrivers.Text = "        Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // pnlSpacer2
            // 
            this.pnlSpacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer2.Enabled = false;
            this.pnlSpacer2.Location = new System.Drawing.Point(0, 630);
            this.pnlSpacer2.Name = "pnlSpacer2";
            this.pnlSpacer2.Size = new System.Drawing.Size(220, 10);
            this.pnlSpacer2.TabIndex = 16;
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.btnPeople.Image = global::DVLD.UI.Properties.Resources.people_24;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 580);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(220, 50);
            this.btnPeople.TabIndex = 11;
            this.btnPeople.Text = "        People";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // pnlSpacer1
            // 
            this.pnlSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer1.Enabled = false;
            this.pnlSpacer1.Location = new System.Drawing.Point(0, 570);
            this.pnlSpacer1.Name = "pnlSpacer1";
            this.pnlSpacer1.Size = new System.Drawing.Size(220, 10);
            this.pnlSpacer1.TabIndex = 17;
            // 
            // pnlApplicationsSubMenu
            // 
            this.pnlApplicationsSubMenu.AutoSize = true;
            this.pnlApplicationsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlApplicationsSubMenu.Controls.Add(this.btnManageTestTypes);
            this.pnlApplicationsSubMenu.Controls.Add(this.btnManageApplicationTypes);
            this.pnlApplicationsSubMenu.Controls.Add(this.pnlDetainLicensesSubMenu);
            this.pnlApplicationsSubMenu.Controls.Add(this.btnDetainLicenses);
            this.pnlApplicationsSubMenu.Controls.Add(this.pnlManageApplicationsSubMenu);
            this.pnlApplicationsSubMenu.Controls.Add(this.btnManageApplications);
            this.pnlApplicationsSubMenu.Controls.Add(this.pnlDrivingLicenseServicesSubMenu);
            this.pnlApplicationsSubMenu.Controls.Add(this.btnDrivingLicenseServices);
            this.pnlApplicationsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlApplicationsSubMenu.Location = new System.Drawing.Point(0, 75);
            this.pnlApplicationsSubMenu.Name = "pnlApplicationsSubMenu";
            this.pnlApplicationsSubMenu.Size = new System.Drawing.Size(220, 495);
            this.pnlApplicationsSubMenu.TabIndex = 10;
            this.pnlApplicationsSubMenu.Visible = false;
            // 
            // btnManageTestTypes
            // 
            this.btnManageTestTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnManageTestTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTestTypes.FlatAppearance.BorderSize = 0;
            this.btnManageTestTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTestTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnManageTestTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnManageTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTestTypes.Location = new System.Drawing.Point(0, 460);
            this.btnManageTestTypes.Name = "btnManageTestTypes";
            this.btnManageTestTypes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnManageTestTypes.Size = new System.Drawing.Size(220, 35);
            this.btnManageTestTypes.TabIndex = 24;
            this.btnManageTestTypes.Text = "Manage Test Types";
            this.btnManageTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTestTypes.UseVisualStyleBackColor = false;
            this.btnManageTestTypes.Click += new System.EventHandler(this.btnManageTestTypes_Click);
            // 
            // btnManageApplicationTypes
            // 
            this.btnManageApplicationTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnManageApplicationTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageApplicationTypes.FlatAppearance.BorderSize = 0;
            this.btnManageApplicationTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnManageApplicationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnManageApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplicationTypes.Location = new System.Drawing.Point(0, 425);
            this.btnManageApplicationTypes.Name = "btnManageApplicationTypes";
            this.btnManageApplicationTypes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnManageApplicationTypes.Size = new System.Drawing.Size(220, 35);
            this.btnManageApplicationTypes.TabIndex = 23;
            this.btnManageApplicationTypes.Text = "Manage Application Types";
            this.btnManageApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplicationTypes.UseVisualStyleBackColor = false;
            this.btnManageApplicationTypes.Click += new System.EventHandler(this.btnManageApplicationTypes_Click);
            // 
            // pnlDetainLicensesSubMenu
            // 
            this.pnlDetainLicensesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlDetainLicensesSubMenu.Controls.Add(this.btnReleaseDetainedLicense);
            this.pnlDetainLicensesSubMenu.Controls.Add(this.btnDetainLicense);
            this.pnlDetainLicensesSubMenu.Controls.Add(this.btnManageDetainedLicenses);
            this.pnlDetainLicensesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetainLicensesSubMenu.Location = new System.Drawing.Point(0, 335);
            this.pnlDetainLicensesSubMenu.Name = "pnlDetainLicensesSubMenu";
            this.pnlDetainLicensesSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlDetainLicensesSubMenu.TabIndex = 22;
            this.pnlDetainLicensesSubMenu.Visible = false;
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnReleaseDetainedLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReleaseDetainedLicense.FlatAppearance.BorderSize = 0;
            this.btnReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDetainedLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnReleaseDetainedLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnReleaseDetainedLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(0, 60);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(220, 30);
            this.btnReleaseDetainedLicense.TabIndex = 19;
            this.btnReleaseDetainedLicense.Text = "Release Detained License";
            this.btnReleaseDetainedLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = false;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnDetainLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetainLicense.FlatAppearance.BorderSize = 0;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(0, 30);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDetainLicense.Size = new System.Drawing.Size(220, 30);
            this.btnDetainLicense.TabIndex = 18;
            this.btnDetainLicense.Text = "Detain License";
            this.btnDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnManageDetainedLicenses
            // 
            this.btnManageDetainedLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnManageDetainedLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageDetainedLicenses.FlatAppearance.BorderSize = 0;
            this.btnManageDetainedLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDetainedLicenses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageDetainedLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnManageDetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDetainedLicenses.Location = new System.Drawing.Point(0, 0);
            this.btnManageDetainedLicenses.Name = "btnManageDetainedLicenses";
            this.btnManageDetainedLicenses.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnManageDetainedLicenses.Size = new System.Drawing.Size(220, 30);
            this.btnManageDetainedLicenses.TabIndex = 17;
            this.btnManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.btnManageDetainedLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDetainedLicenses.UseVisualStyleBackColor = false;
            this.btnManageDetainedLicenses.Click += new System.EventHandler(this.btnManageDetainedLicenses_Click);
            // 
            // btnDetainLicenses
            // 
            this.btnDetainLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnDetainLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetainLicenses.FlatAppearance.BorderSize = 0;
            this.btnDetainLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicenses.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnDetainLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicenses.Location = new System.Drawing.Point(0, 300);
            this.btnDetainLicenses.Name = "btnDetainLicenses";
            this.btnDetainLicenses.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnDetainLicenses.Size = new System.Drawing.Size(220, 35);
            this.btnDetainLicenses.TabIndex = 21;
            this.btnDetainLicenses.Text = "Detain Licenses ▸";
            this.btnDetainLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicenses.UseVisualStyleBackColor = false;
            this.btnDetainLicenses.Click += new System.EventHandler(this.btnDetainLicenses_Click);
            // 
            // pnlManageApplicationsSubMenu
            // 
            this.pnlManageApplicationsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlManageApplicationsSubMenu.Controls.Add(this.btnInternationalLicenseApplications);
            this.pnlManageApplicationsSubMenu.Controls.Add(this.btnLocalDrivingLicenseApplications);
            this.pnlManageApplicationsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageApplicationsSubMenu.Location = new System.Drawing.Point(0, 240);
            this.pnlManageApplicationsSubMenu.Name = "pnlManageApplicationsSubMenu";
            this.pnlManageApplicationsSubMenu.Size = new System.Drawing.Size(220, 60);
            this.pnlManageApplicationsSubMenu.TabIndex = 20;
            this.pnlManageApplicationsSubMenu.Visible = false;
            // 
            // btnInternationalLicenseApplications
            // 
            this.btnInternationalLicenseApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnInternationalLicenseApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInternationalLicenseApplications.FlatAppearance.BorderSize = 0;
            this.btnInternationalLicenseApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternationalLicenseApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnInternationalLicenseApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnInternationalLicenseApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicenseApplications.Location = new System.Drawing.Point(0, 30);
            this.btnInternationalLicenseApplications.Name = "btnInternationalLicenseApplications";
            this.btnInternationalLicenseApplications.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInternationalLicenseApplications.Size = new System.Drawing.Size(220, 30);
            this.btnInternationalLicenseApplications.TabIndex = 18;
            this.btnInternationalLicenseApplications.Text = "International Applications";
            this.btnInternationalLicenseApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicenseApplications.UseVisualStyleBackColor = false;
            this.btnInternationalLicenseApplications.Click += new System.EventHandler(this.btnInternationalLicenseApplications_Click);
            // 
            // btnLocalDrivingLicenseApplications
            // 
            this.btnLocalDrivingLicenseApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnLocalDrivingLicenseApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocalDrivingLicenseApplications.FlatAppearance.BorderSize = 0;
            this.btnLocalDrivingLicenseApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalDrivingLicenseApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLocalDrivingLicenseApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnLocalDrivingLicenseApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalDrivingLicenseApplications.Location = new System.Drawing.Point(0, 0);
            this.btnLocalDrivingLicenseApplications.Name = "btnLocalDrivingLicenseApplications";
            this.btnLocalDrivingLicenseApplications.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLocalDrivingLicenseApplications.Size = new System.Drawing.Size(220, 30);
            this.btnLocalDrivingLicenseApplications.TabIndex = 17;
            this.btnLocalDrivingLicenseApplications.Text = "Local Applications";
            this.btnLocalDrivingLicenseApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalDrivingLicenseApplications.UseVisualStyleBackColor = false;
            this.btnLocalDrivingLicenseApplications.Click += new System.EventHandler(this.btnLocalDrivingLicenseApplications_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnManageApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageApplications.FlatAppearance.BorderSize = 0;
            this.btnManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnManageApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnManageApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.Location = new System.Drawing.Point(0, 205);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnManageApplications.Size = new System.Drawing.Size(220, 35);
            this.btnManageApplications.TabIndex = 15;
            this.btnManageApplications.Text = "Manage Applications ▸";
            this.btnManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.UseVisualStyleBackColor = false;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // pnlDrivingLicenseServicesSubMenu
            // 
            this.pnlDrivingLicenseServicesSubMenu.AutoSize = true;
            this.pnlDrivingLicenseServicesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlDrivingLicenseServicesSubMenu.Controls.Add(this.btnRetakeTest);
            this.pnlDrivingLicenseServicesSubMenu.Controls.Add(this.btnReplacement);
            this.pnlDrivingLicenseServicesSubMenu.Controls.Add(this.btnRenewLicense);
            this.pnlDrivingLicenseServicesSubMenu.Controls.Add(this.pnlNewDrivingLicenseSubMenu);
            this.pnlDrivingLicenseServicesSubMenu.Controls.Add(this.btnNewDrivingLicense);
            this.pnlDrivingLicenseServicesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrivingLicenseServicesSubMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlDrivingLicenseServicesSubMenu.Name = "pnlDrivingLicenseServicesSubMenu";
            this.pnlDrivingLicenseServicesSubMenu.Size = new System.Drawing.Size(220, 170);
            this.pnlDrivingLicenseServicesSubMenu.TabIndex = 13;
            this.pnlDrivingLicenseServicesSubMenu.Visible = false;
            // 
            // btnRetakeTest
            // 
            this.btnRetakeTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnRetakeTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRetakeTest.FlatAppearance.BorderSize = 0;
            this.btnRetakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetakeTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRetakeTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnRetakeTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetakeTest.Location = new System.Drawing.Point(0, 140);
            this.btnRetakeTest.Name = "btnRetakeTest";
            this.btnRetakeTest.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRetakeTest.Size = new System.Drawing.Size(220, 30);
            this.btnRetakeTest.TabIndex = 16;
            this.btnRetakeTest.Text = "Retake Test";
            this.btnRetakeTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetakeTest.UseVisualStyleBackColor = false;
            this.btnRetakeTest.Click += new System.EventHandler(this.btnRetakeTest_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnReplacement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReplacement.FlatAppearance.BorderSize = 0;
            this.btnReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacement.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnReplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplacement.Location = new System.Drawing.Point(0, 110);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReplacement.Size = new System.Drawing.Size(220, 30);
            this.btnReplacement.TabIndex = 15;
            this.btnReplacement.Text = "Replace Lost/Damaged License";
            this.btnReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplacement.UseVisualStyleBackColor = false;
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // btnRenewLicense
            // 
            this.btnRenewLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnRenewLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRenewLicense.FlatAppearance.BorderSize = 0;
            this.btnRenewLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRenewLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnRenewLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenewLicense.Location = new System.Drawing.Point(0, 80);
            this.btnRenewLicense.Name = "btnRenewLicense";
            this.btnRenewLicense.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRenewLicense.Size = new System.Drawing.Size(220, 30);
            this.btnRenewLicense.TabIndex = 14;
            this.btnRenewLicense.Text = "Renew Driving License";
            this.btnRenewLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenewLicense.UseVisualStyleBackColor = false;
            this.btnRenewLicense.Click += new System.EventHandler(this.btnRenewLicense_Click);
            // 
            // pnlNewDrivingLicenseSubMenu
            // 
            this.pnlNewDrivingLicenseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlNewDrivingLicenseSubMenu.Controls.Add(this.btnInternationalLicense);
            this.pnlNewDrivingLicenseSubMenu.Controls.Add(this.btnLocalLicense);
            this.pnlNewDrivingLicenseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewDrivingLicenseSubMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlNewDrivingLicenseSubMenu.Name = "pnlNewDrivingLicenseSubMenu";
            this.pnlNewDrivingLicenseSubMenu.Size = new System.Drawing.Size(220, 50);
            this.pnlNewDrivingLicenseSubMenu.TabIndex = 12;
            this.pnlNewDrivingLicenseSubMenu.Visible = false;
            // 
            // btnInternationalLicense
            // 
            this.btnInternationalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnInternationalLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInternationalLicense.FlatAppearance.BorderSize = 0;
            this.btnInternationalLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternationalLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnInternationalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicense.Location = new System.Drawing.Point(0, 25);
            this.btnInternationalLicense.Name = "btnInternationalLicense";
            this.btnInternationalLicense.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnInternationalLicense.Size = new System.Drawing.Size(220, 25);
            this.btnInternationalLicense.TabIndex = 18;
            this.btnInternationalLicense.Text = "International Driving License";
            this.btnInternationalLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicense.UseVisualStyleBackColor = false;
            this.btnInternationalLicense.Click += new System.EventHandler(this.btnInternationalLicense_Click);
            // 
            // btnLocalLicense
            // 
            this.btnLocalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnLocalLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocalLicense.FlatAppearance.BorderSize = 0;
            this.btnLocalLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnLocalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicense.Location = new System.Drawing.Point(0, 0);
            this.btnLocalLicense.Name = "btnLocalLicense";
            this.btnLocalLicense.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnLocalLicense.Size = new System.Drawing.Size(220, 25);
            this.btnLocalLicense.TabIndex = 17;
            this.btnLocalLicense.Text = "Local Driving License";
            this.btnLocalLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicense.UseVisualStyleBackColor = false;
            this.btnLocalLicense.Click += new System.EventHandler(this.btnLocalLicense_Click);
            // 
            // btnNewDrivingLicense
            // 
            this.btnNewDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnNewDrivingLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnNewDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDrivingLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDrivingLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnNewDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDrivingLicense.Location = new System.Drawing.Point(0, 0);
            this.btnNewDrivingLicense.Name = "btnNewDrivingLicense";
            this.btnNewDrivingLicense.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNewDrivingLicense.Size = new System.Drawing.Size(220, 30);
            this.btnNewDrivingLicense.TabIndex = 13;
            this.btnNewDrivingLicense.Text = "New Driving License ▸";
            this.btnNewDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDrivingLicense.UseVisualStyleBackColor = false;
            this.btnNewDrivingLicense.Click += new System.EventHandler(this.btnNewDrivingLicense_Click);
            // 
            // btnDrivingLicenseServices
            // 
            this.btnDrivingLicenseServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnDrivingLicenseServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivingLicenseServices.FlatAppearance.BorderSize = 0;
            this.btnDrivingLicenseServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivingLicenseServices.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingLicenseServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.btnDrivingLicenseServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicenseServices.Location = new System.Drawing.Point(0, 0);
            this.btnDrivingLicenseServices.Name = "btnDrivingLicenseServices";
            this.btnDrivingLicenseServices.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnDrivingLicenseServices.Size = new System.Drawing.Size(220, 35);
            this.btnDrivingLicenseServices.TabIndex = 12;
            this.btnDrivingLicenseServices.Text = "Driving License Services ▸";
            this.btnDrivingLicenseServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicenseServices.UseVisualStyleBackColor = false;
            this.btnDrivingLicenseServices.Click += new System.EventHandler(this.btnDrivingLicenseServices_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btnApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.btnApplications.Image = global::DVLD.UI.Properties.Resources.applications_24;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.Location = new System.Drawing.Point(0, 25);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(220, 50);
            this.btnApplications.TabIndex = 8;
            this.btnApplications.Text = "        Applications ▸";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // pnlTopSpacer
            // 
            this.pnlTopSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSpacer.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSpacer.Name = "pnlTopSpacer";
            this.pnlTopSpacer.Size = new System.Drawing.Size(220, 25);
            this.pnlTopSpacer.TabIndex = 10;
            // 
            // pnlSidebar2
            // 
            this.pnlSidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.pnlSidebar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar2.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar2.Name = "pnlSidebar2";
            this.pnlSidebar2.Size = new System.Drawing.Size(25, 912);
            this.pnlSidebar2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(245, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 912);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD.UI.Properties.Resources.Transparency;
            this.pictureBox1.Location = new System.Drawing.Point(270, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 912);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1041, 912);
            this.Controls.Add(this.lblWelcomeUserLine2);
            this.Controls.Add(this.lblWelcomeUserLine1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlSidebar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlAccountSettingsSubMenu.ResumeLayout(false);
            this.pnlAccountSettings.ResumeLayout(false);
            this.pnlApplicationsSubMenu.ResumeLayout(false);
            this.pnlApplicationsSubMenu.PerformLayout();
            this.pnlDetainLicensesSubMenu.ResumeLayout(false);
            this.pnlManageApplicationsSubMenu.ResumeLayout(false);
            this.pnlDrivingLicenseServicesSubMenu.ResumeLayout(false);
            this.pnlNewDrivingLicenseSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeUserLine1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcomeUserLine2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Panel pnlSpacer2;
        private System.Windows.Forms.Panel pnlSpacer3;
        private System.Windows.Forms.Panel pnlSpacer1;
        private System.Windows.Forms.Panel pnlSpacer4;
        private System.Windows.Forms.Panel pnlSidebar2;
        private System.Windows.Forms.Panel pnlAccountSettings;
        private System.Windows.Forms.Panel pnlAccountSettingsSubMenu;
        private System.Windows.Forms.Panel pnlApplicationsSubMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCurrentUserInfo;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnDrivingLicenseServices;
        private System.Windows.Forms.Button btnManageApplications;
        private System.Windows.Forms.Panel pnlManageApplicationsSubMenu;
        private System.Windows.Forms.Button btnInternationalLicenseApplications;
        private System.Windows.Forms.Button btnLocalDrivingLicenseApplications;
        private System.Windows.Forms.Panel pnlDetainLicensesSubMenu;
        private System.Windows.Forms.Button btnReleaseDetainedLicense;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Button btnManageDetainedLicenses;
        private System.Windows.Forms.Button btnDetainLicenses;
        private System.Windows.Forms.Button btnManageApplicationTypes;
        private System.Windows.Forms.Button btnManageTestTypes;
        private System.Windows.Forms.Panel pnlDrivingLicenseServicesSubMenu;
        private System.Windows.Forms.Button btnRetakeTest;
        private System.Windows.Forms.Button btnReplacement;
        private System.Windows.Forms.Button btnRenewLicense;
        private System.Windows.Forms.Panel pnlNewDrivingLicenseSubMenu;
        private System.Windows.Forms.Button btnInternationalLicense;
        private System.Windows.Forms.Button btnLocalLicense;
        private System.Windows.Forms.Button btnNewDrivingLicense;
        private System.Windows.Forms.Panel pnlTopSpacer;
        private System.Windows.Forms.Panel panel1;
    }
}

