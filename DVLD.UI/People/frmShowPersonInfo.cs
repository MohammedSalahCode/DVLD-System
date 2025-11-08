using System;
using System.Windows.Forms;


namespace DVLD.UI
{
    public partial class frmShowPersonInfo: Form
    {
        int _PersonID;

        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
