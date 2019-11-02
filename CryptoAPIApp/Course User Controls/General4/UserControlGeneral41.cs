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
    public partial class UserControlGeneral41 : UserControl
    {
        public UserControlGeneral41()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral4 ucg4 = new UserControlGeneral4();
            ucg4.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg4);
            ucg4.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral42 ucg42 = new UserControlGeneral42();
            ucg42.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg42);
            ucg42.BringToFront();
        }
    }
}
