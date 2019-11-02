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
    public partial class UserControlGeneral42 : UserControl
    {
        public UserControlGeneral42()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral41 ucg41 = new UserControlGeneral41();
            ucg41.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg41);
            ucg41.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral43 ucg43 = new UserControlGeneral43();
            ucg43.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg43);
            ucg43.BringToFront();
        }
    }
}
