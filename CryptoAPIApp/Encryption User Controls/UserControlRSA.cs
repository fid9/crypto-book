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
    public partial class UserControlRSA : UserControl
    {
        public UserControlRSA()
        {
            InitializeComponent();
        }

        UTF8Encoding ByteConverter = new UTF8Encoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (textboxplaintext.Text == "")
            {
                textboxencrypted.Text = "";
                return;
            }
            plaintext = ByteConverter.GetBytes(textboxplaintext.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            textboxencrypted.Text = ByteConverter.GetString(encryptedtext);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {

            if (textboxencrypted.Text == "")
                {
                    textboxdecrypted.Text = "";
                    return;
                }
            
            byte[] decryptedtext = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            textboxdecrypted.Text = ByteConverter.GetString(decryptedtext);
        }

        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        //Method for Decryption
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);   //nuk osht i validum

                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Textboxdecrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textboxplaintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textboxencrypted_TextChanged(object sender, EventArgs e)
        {

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
