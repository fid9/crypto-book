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
    public partial class UserControlRSAS : UserControl
    {
        public UserControlRSAS()
        {
            InitializeComponent();

        }

        //BtnEncrypt is the 'Sign' button
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxplaintext.Text == "") return;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                string privateKey = RSA.ToXmlString(true);
                string publicKey = RSA.ToXmlString(false);

                RSA.FromXmlString(privateKey);
                RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);
                RSAFormatter.SetHashAlgorithm("SHA1");
                SHA1Managed SHhash = new SHA1Managed();
                byte[] SignedHashValue = RSAFormatter.CreateSignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxplaintext.Text)));
                textboxsigned.Text = Convert.ToBase64String(SignedHashValue); 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BtnDecrypt is the 'Verify' button

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                string privateKey = RSA.ToXmlString(true);
                string publicKey = RSA.ToXmlString(true);


                RSA.FromXmlString(publicKey);
                RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
                RSADeformatter.SetHashAlgorithm("SHA1");
                SHA1Managed SHhash = new SHA1Managed();
                
                
                    if (RSADeformatter.VerifySignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxplaintext.Text)),
                    Convert.FromBase64String(textboxsigned.Text))           //the error displays here
)
                    {

                        MessageBox.Show("The signature is valid.");
                        /// The signature is valid.
                    }
                    else
                    {
                        MessageBox.Show("The signature is not valid.");
                        /// The signature is not valid.
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControlRSAS_Load(object sender, EventArgs e)
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
