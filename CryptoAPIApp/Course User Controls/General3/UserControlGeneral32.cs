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
    public partial class UserControlGeneral32 : UserControl
    {
        public UserControlGeneral32()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral31 ucg31 = new UserControlGeneral31();
            ucg31.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg31);
            ucg31.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral33 ucg33 = new UserControlGeneral33();
            ucg33.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg33);
            ucg33.BringToFront();
        }
    }
}
