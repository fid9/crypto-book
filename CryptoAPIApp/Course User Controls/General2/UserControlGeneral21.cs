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
    public partial class UserControlGeneral21 : UserControl
    {
        public UserControlGeneral21()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral2 ucg2 = new UserControlGeneral2();
            ucg2.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg2);
            ucg2.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral22 ucg22 = new UserControlGeneral22();
            ucg22.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg22);
            ucg22.BringToFront();
        }
    }
}
