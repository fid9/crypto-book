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
    public partial class UserControlGeneral93cs : UserControl
    {
        public UserControlGeneral93cs()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral92"))
            {
                UserControlGeneral92 ucal = new UserControlGeneral92();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral92"].BringToFront();
        }
    }
}
