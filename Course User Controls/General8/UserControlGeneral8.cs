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
    public partial class UserControlGeneral8 : UserControl
    {
        public UserControlGeneral8()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral"))
            {
                UserControlGeneral ucal = new UserControlGeneral();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral"].BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral81"))
            {
                UserControlGeneral81 ucal = new UserControlGeneral81();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral81"].BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral"))
            {
                UserControlGeneral ucal = new UserControlGeneral();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral"].BringToFront();
        }
    }
}
