using System;
using System.Windows.Forms;

namespace DVLD.UI.User
{
    public partial class frmUserInfo: Form
    {
        private int _UserID;

        public frmUserInfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
