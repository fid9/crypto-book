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
    public partial class UserControlGeneral22 : UserControl
    {
        public UserControlGeneral22()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral21 ucg21 = new UserControlGeneral21();
            ucg21.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg21);
            ucg21.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral23 ucg23 = new UserControlGeneral23();
            ucg23.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg23);
            ucg23.BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
