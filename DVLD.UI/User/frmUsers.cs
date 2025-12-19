using DVLD.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.UI.User
{
    public partial class frmUsers: Form
    {
        private static DataTable _dtAllUsers;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();

            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();


            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 100;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 250;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 100;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 80;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser();
            Frm1.ShowDialog();
            frmUsers_Load(null, null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser();
            Frm1.ShowDialog();
            frmUsers_Load(null, null);
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            frmUsers_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete User [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Perform delete and refresh the list
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("User has been deleted successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            Form frm = new frmChangePassword(UserID);

            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFilterValue.Visible = (cbFilterBy.Text != "None");

            cbIsActive.Visible = (cbFilterBy.Text == "Is Active");

            if (cbIsActive.Visible)
                cbIsActive.SelectedIndex = 0;

            if (textFilterValue.Visible)
            {
                textFilterValue.Text = "";
                textFilterValue.Focus();
            }
        }

        private void textFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            //Map Selected Filter to Column name 
            switch (cbFilterBy.Text)
            {

                case "User ID": filterColumn = "UserID"; break;
                case "Person ID": filterColumn = "PersonID"; break;
                case "Full Name": filterColumn = "FullName"; break;
                case "UserName": filterColumn = "UserName"; break;
                default: filterColumn = "None"; break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (filterColumn == "None" || string.IsNullOrWhiteSpace(textFilterValue.Text))
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            // Apply filter based on selected column type
            if (filterColumn != "FullName" && filterColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, textFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, textFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllUsers.DefaultView.Count.ToString();
        }

        private void cbIaActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn = "IsActive";
            string filterValue = cbIsActive.Text;

            switch (filterValue)
            {
                case "All":
                    break;
                case "Yes":
                    filterValue = "1";
                    break;
                case "No":
                    filterValue = "0";
                    break;
            }


            if (filterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                // Filter IsActive using 0 (No) and 1 (Yes)
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, filterValue);

            lblRecordsCount.Text = _dtAllUsers.DefaultView.Count.ToString();
        }

        private void dgvUsers_CellDoubleClick(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
