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
    public partial class UserControlGeneral : UserControl
    {
        public UserControlGeneral()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            UserControlGeneral0 ucg0 = new UserControlGeneral0();
            ucg0.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg0);
            ucg0.BringToFront();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserControlGeneral1 ucg1 = new UserControlGeneral1();
            ucg1.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg1);
            ucg1.BringToFront();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserControlGeneral2 ucg2 = new UserControlGeneral2();
            ucg2.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg2);
            ucg2.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserControlGeneral3 ucg3 = new UserControlGeneral3();
            ucg3.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg3);
            ucg3.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UserControlGeneral4 ucg4 = new UserControlGeneral4();
            ucg4.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg4);
            ucg4.BringToFront();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UserControlGeneral5 ucg5 = new UserControlGeneral5();
            ucg5.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg5);
            ucg5.BringToFront();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral6"))
            {
                UserControlGeneral6 ucal = new UserControlGeneral6();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral6"].BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral7"))
            {
                UserControlGeneral7 ucal = new UserControlGeneral7();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral7"].BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral8"))
            {
                UserControlGeneral8 ucal = new UserControlGeneral8();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral8"].BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlGeneral9"))
            {
                UserControlGeneral9 ucal = new UserControlGeneral9();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlGeneral9"].BringToFront();
        }
    }
}
