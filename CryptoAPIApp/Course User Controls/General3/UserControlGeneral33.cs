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
    public partial class UserControlGeneral33 : UserControl
    {
        public UserControlGeneral33()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral32 ucg32 = new UserControlGeneral32();
            ucg32.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg32);
            ucg32.BringToFront();
        }
    }
}
