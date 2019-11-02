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
    public partial class UserControlGeneral43 : UserControl
    {
        public UserControlGeneral43()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral42 ucg42 = new UserControlGeneral42();
            ucg42.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg42);
            ucg42.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral44 ucg44 = new UserControlGeneral44();
            ucg44.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg44);
            ucg44.BringToFront();
        }
    }
}
