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
    public partial class UserControl3DES : UserControl
    {
        public UserControl3DES()
        {
            InitializeComponent();
        }

        byte[] encrypted;
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (textboxkey.Text == "") return;
            if (textboxplaintext.Text == "") return;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
            tDES.Key = md5.ComputeHash(utf8.GetBytes(textboxkey.Text));
            tDES.Mode = CipherMode.ECB;
            tDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tDES.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(utf8.GetBytes(textboxplaintext.Text), 0, utf8.GetBytes(textboxplaintext.Text).Length);
            textboxencrypted.Text = BitConverter.ToString(encrypted);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxkey2.Text == "") return;

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
                tDES.Key = md5.ComputeHash(utf8.GetBytes(textBoxkey2.Text));                   
                tDES.Mode = CipherMode.ECB;
                tDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform trans = tDES.CreateDecryptor();

                textboxdecrypted.Text = utf8.GetString(trans.TransformFinalBlock(encrypted, 0, encrypted.Length));
            }

            catch (Exception)
            {
                MessageBox.Show("Your key is invalid!");
            }
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
