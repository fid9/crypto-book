using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CryptoAPIApp
{
    public partial class UserControlSHA1 : UserControl
    {
        public UserControlSHA1()
        {
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            if (textboxkey.Text == "") return;
            if (textBox1.Text == "") return;

            UTF8Encoding utf8 = new UTF8Encoding();
            HMACSHA1 hMASHA1 = new HMACSHA1(utf8.GetBytes(textboxkey.Text));
            byte[] hashmessage = hMASHA1.ComputeHash(utf8.GetBytes(textBox1.Text));
            textboxhashed.Text = BitConverter.ToString(hashmessage);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlAlgorithms"))
            {
                UserControlAlgorithms ucal = new UserControlAlgorithms();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlAlgorithms"].BringToFront();
        }
    }
}
