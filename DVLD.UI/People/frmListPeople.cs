using DVLD.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.UI
{
    public partial class frmListPeople: Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                 "FirstName", "SecondName", "ThirdName", "LastName",
                                                 "Gender", "DateOfBirth", "CountryName",
                                                 "Phone", "Email");

        public frmListPeople()
        {
            InitializeComponent();
        }

        void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                           "FirstName", "SecondName", "ThirdName", "LastName",
                                           "Gender", "DateOfBirth", "CountryName",
                                           "Phone", "Email");


            dgvPeople.DataSource = _dtPeople;

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns["PersonID"].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 80;

                dgvPeople.Columns["NationalNo"].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 80;

                dgvPeople.Columns["FirstName"].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 110;

                dgvPeople.Columns["SecondName"].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns["ThirdName"].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 100;

                dgvPeople.Columns["LastName"].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 80;

                dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 120;

                dgvPeople.Columns["CountryName"].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 80;

                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 110;
            }
        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            //Map Selected Filter to Column name 
            switch (cbFilterBy.Text)
            {
                case "Person ID": filterColumn = "PersonID"; break;
                case "National No.": filterColumn = "NationalNo"; break;
                case "First Name": filterColumn = "FirstName"; break;
                case "Second Name": filterColumn = "SecondName"; break;
                case "Last Name": filterColumn = "LastName"; break;
                case "Gender": filterColumn = "Gender"; break;
                case "Date Of Birth": filterColumn = "DateOfBirth"; break;
                case "CountryName": filterColumn = "Nationality"; break;
                case "Phone": filterColumn = "Phone"; break;
                case "Email": filterColumn = "Email"; break;
                default: filterColumn = "None"; break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (filterColumn == "None" || string.IsNullOrWhiteSpace(textFilterValue.Text))
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            // Apply filter based on selected column type
            if (filterColumn == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, textFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, textFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFilterValue.Visible = (cbFilterBy.Text != "None");

            if (textFilterValue.Visible)
            {
                textFilterValue.Text = "";
                textFilterValue.Focus();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();

            frm.ShowDialog();

            _RefreshPeoplList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshPeoplList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform delete and refresh the list
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person deleted successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow number incase person id is selected.
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
