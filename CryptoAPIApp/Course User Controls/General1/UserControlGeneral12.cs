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
    public partial class UserControlGeneral12 : UserControl
    {
        public UserControlGeneral12()
        {
            InitializeComponent();
        }

        private void CircularButton1_Click(object sender, EventArgs e)
        {
            UserControlGeneral11 ucg11 = new UserControlGeneral11();
            ucg11.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg11);
            ucg11.BringToFront();
        }

        private void CircularButton2_Click(object sender, EventArgs e)
        {
            UserControlGeneral13 ucg13 = new UserControlGeneral13();
            ucg13.Dock = DockStyle.Fill;
            FrmMain.Instance.PnlContainer.Controls.Add(ucg13);
            ucg13.BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
