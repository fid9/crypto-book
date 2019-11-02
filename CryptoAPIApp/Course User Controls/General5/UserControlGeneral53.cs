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
    public partial class UserControlGeneral53 : UserControl
    {
        public UserControlGeneral53()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral52 ucg52 = new UserControlGeneral52();
            ucg52.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg52);
            ucg52.BringToFront();
        }
    }
}
