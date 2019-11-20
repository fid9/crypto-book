using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CryptoAPIApp
{
    public partial class UserControlMD5 : UserControl
    {
        public UserControlMD5()
        {
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            UTF8Encoding utf8 = new UTF8Encoding(); 
            HMACMD5 hMACMD5 = new HMACMD5(utf8.GetBytes(textboxkey.Text));
            byte[] hashmessage = hMACMD5.ComputeHash(utf8.GetBytes(textBox1.Text));
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
