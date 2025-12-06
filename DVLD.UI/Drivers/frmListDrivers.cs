using DVLD.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.UI.Drivers
{
    public partial class frmListDrivers: Form
    {
        private DataTable _dtAllDrivers;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;

            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 85;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 85;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 85;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 250;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 150;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 80;
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;

            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFilterValue.Visible = (cbFilterBy.Text != "None");

            if (textFilterValue.Visible)
            {
                textFilterValue.Text = "";
                textFilterValue.Focus();
            }

            _dtAllDrivers.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Driver ID": FilterColumn = "DriverID"; break;
                case "Person ID": FilterColumn = "PersonID"; break;
                case "National No.": FilterColumn = "NationalNo"; break;
                case "Full Name": FilterColumn = "FullName"; break;
                default: FilterColumn = "None"; break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrWhiteSpace(textFilterValue.Text) || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            // Apply filter based on selected column type
            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textFilterValue.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();

        }

        private void textFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TODO: Implement Person License History feature
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet.");
        }
    }
}
