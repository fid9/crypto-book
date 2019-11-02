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
    public partial class UserControlGeneral52 : UserControl
    {
        public UserControlGeneral52()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral51 ucg51 = new UserControlGeneral51();
            ucg51.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg51);
            ucg51.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral53 ucg53 = new UserControlGeneral53();
            ucg53.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg53);
            ucg53.BringToFront();
        }
    }
}
