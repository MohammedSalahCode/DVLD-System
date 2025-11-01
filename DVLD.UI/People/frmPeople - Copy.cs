using DVLD.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.UI
{
    public partial class frmPeople: Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private DataView ListPeopleView;

        void _RefreshPeople()
        {
            ListPeopleView = new DataView(clsPerson.GetAllPeople());

            dgvShowPeople.DataSource = ListPeopleView;


            dgvShowPeople.Columns["PersonID"].HeaderText = "Person ID";
            dgvShowPeople.Columns[0].Width = 80;

            dgvShowPeople.Columns["NationalNo"].HeaderText = "National No.";
            dgvShowPeople.Columns[1].Width = 80;

            dgvShowPeople.Columns["FirstName"].HeaderText = "First Name";
            dgvShowPeople.Columns[2].Width = 110;

            dgvShowPeople.Columns["SecondName"].HeaderText = "Second Name";
            dgvShowPeople.Columns[3].Width = 120;

            dgvShowPeople.Columns["ThirdName"].HeaderText = "Third Name";
            dgvShowPeople.Columns[4].Width = 100;

            dgvShowPeople.Columns["LastName"].HeaderText = "Last Name";
            dgvShowPeople.Columns[5].Width = 120;

            dgvShowPeople.Columns[6].HeaderText = "Gender";
            dgvShowPeople.Columns[6].Width = 80;

            dgvShowPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            dgvShowPeople.Columns[7].Width = 120;

            dgvShowPeople.Columns["CountryName"].HeaderText = "Nationality";
            dgvShowPeople.Columns[8].Width = 80;

            dgvShowPeople.Columns[9].HeaderText = "Phone";
            dgvShowPeople.Columns[9].Width = 120;


            dgvShowPeople.Columns[10].HeaderText = "Email";
            dgvShowPeople.Columns[10].Width = 110;


            lblPeople_Count.Text = dgvShowPeople.RowCount.ToString();

        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;

            _RefreshPeople();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            DataView AddEditView = new DataView(ListPeopleView.Table); // copy from main view


            frmAddEditPeople frm = new frmAddEditPeople();

            frm.ShowDialog();

            _RefreshPeople();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            DataView AddEditView = new DataView(ListPeopleView.Table); // copy from main view

            //frmAddEditPeople frm = new frmAddEditPeople((int)dgvShowPeople.CurrentRow.Cells[0].Value, AddEditView);

            //frm.ShowDialog();

            _RefreshPeople();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvShowPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                //Perform Delete and refresh
                if (clsPerson.DeletePerson((int)dgvShowPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.");
                    _RefreshPeople();
                }
                else
                {
                    MessageBox.Show("Person is not deleted.");
                }

            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.Text == "None")
                textFilterValue.Enabled = false;
            else
                textFilterValue.Enabled = true;

        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None" ||string.IsNullOrEmpty(textFilterValue.Text))
            {
                ListPeopleView.RowFilter = "";
                return;
            }


            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "None":
                    ListPeopleView.RowFilter = "";
                    break;

                case "Person ID":
                    // هنا اذا عملت اسبيس بضرب
                    ListPeopleView.RowFilter = $"PersonID = {textFilterValue.Text}";
                    break;

                case "National No.":
                    ListPeopleView.RowFilter = $"NationalNo = '{textFilterValue.Text}'";

                    break;

                case "First Name":
                    ListPeopleView.RowFilter = $"FirstName LIKE '%{textFilterValue.Text}%'";

                    break;

                case "Last Name":
                    ListPeopleView.RowFilter = $"LastName = '{textFilterValue.Text}'";

                    break;

                case "Gender":
                    ListPeopleView.RowFilter = $"Gender = '{textFilterValue.Text}'";

                    break;

                case "Date Of Birth":

                    if (DateTime.TryParse(textFilterValue.Text, out DateTime date))
                        ListPeopleView.RowFilter = $"DateOfBirth = #{date:MM/dd/yyyy}#";
                    else
                        ListPeopleView.RowFilter = "";

                    break;


                case "CountryName":
                    ListPeopleView.RowFilter = $"Nationality = '{textFilterValue.Text}'";

                    break;

                case "Phone":
                    ListPeopleView.RowFilter = $"Phone = '{textFilterValue.Text}'";

                    break;

                case "Email":
                    ListPeopleView.RowFilter = $"Email = '{textFilterValue.Text}'";

                    break;

                default:
                    MessageBox.Show("Unknown filter option selected!");
                    break;
            }


            //string FilterBy = cbFilterBy.Text;






            //string FilterValue = textFilterValue.Text;

            //ListPeopleView.RowFilter = ($"{FilterBy} = '{FilterValue}'");

            //_dvPeople.RowFilter = $"NationalNo = '{nationalNo}' AND PersonID <> {_PersonID}";



        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPersonDetails frm = new frmPersonDetails((int)dgvShowPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();


        }
    }
}
