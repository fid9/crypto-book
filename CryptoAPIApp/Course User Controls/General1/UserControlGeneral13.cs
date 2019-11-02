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
    public partial class UserControlGeneral13 : UserControl
    {
        public UserControlGeneral13()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral12 ucg12 = new UserControlGeneral12();
            ucg12.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg12);
            ucg12.BringToFront();
        }
    }
}
