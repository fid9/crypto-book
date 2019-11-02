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
    public partial class UserControlGeneral11 : UserControl
    {
        public UserControlGeneral11()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral1 ucg1 = new UserControlGeneral1();
            ucg1.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg1);
            ucg1.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral12 ucg12 = new UserControlGeneral12();
            ucg12.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg12);
            ucg12.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral"))
            {
                UserControlGeneral ucal = new UserControlGeneral();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral"].BringToFront();
        }
    }
}
