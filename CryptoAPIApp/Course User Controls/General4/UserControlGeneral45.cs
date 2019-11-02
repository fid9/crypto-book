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
    public partial class UserControlGeneral45 : UserControl
    {
        public UserControlGeneral45()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {

        }

        private void CircularButton1_Click_1(object sender, EventArgs e)
        {
            UserControlGeneral44 ucg44 = new UserControlGeneral44();
            ucg44.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg44);
            ucg44.BringToFront();
        }
    }
}
