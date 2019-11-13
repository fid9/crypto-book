using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class UserControlHome : UserControl 
    {
        public UserControlHome()
        {
            InitializeComponent();
        }
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            UserControlAlgorithms ucag = new UserControlAlgorithms();
            ucag.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucag);
            FrmMain.Instance.Sidepanel1.Height = FrmMain.Instance.Button8.Height;
            FrmMain.Instance.Sidepanel1.Top = FrmMain.Instance.Button8.Top;

            ucag.BringToFront();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserControlGeneral ucg = new UserControlGeneral();
            ucg.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg);
            ucg.BringToFront();
            FrmMain.Instance.Sidepanel1.Height = FrmMain.Instance.Button3.Height;
            FrmMain.Instance.Sidepanel1.Top = FrmMain.Instance.Button3.Top;

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {

        }
    }
}
