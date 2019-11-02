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
    public partial class UserControlGeneral4 : UserControl
    {
        public UserControlGeneral4()
        {
            InitializeComponent();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral41 ucg41 = new UserControlGeneral41();
            ucg41.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg41);
            ucg41.BringToFront();
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
