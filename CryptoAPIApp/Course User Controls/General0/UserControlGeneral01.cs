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
    public partial class UserControlGeneral01 : UserControl
    {
        public UserControlGeneral01()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral0 ucg0 = new UserControlGeneral0();
            ucg0.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg0);
            ucg0.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral02 ucg02 = new UserControlGeneral02();
            ucg02.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg02);
            ucg02.BringToFront();
        }
    }
}
