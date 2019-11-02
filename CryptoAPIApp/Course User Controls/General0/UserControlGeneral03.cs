using System;
using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class UserControlGeneral03 : UserControl
    {
        public UserControlGeneral03()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral02 ucg02 = new UserControlGeneral02();
            ucg02.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg02);
            ucg02.BringToFront();
        }
    }
}
