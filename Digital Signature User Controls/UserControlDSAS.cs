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
    public partial class UserControlDSAS : UserControl
    {
        public UserControlDSAS()
        {   
            InitializeComponent();
            DSAC = new DSACryptoServiceProvider();
            string privateKey = DSAC.ToXmlString(true);
            string publicKey = DSAC.ToXmlString(false);
        }

        AsymmetricAlgorithm DSAC;
        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (textboxplaintext.Text == "") return;
            DSASignatureFormatter DSAFormatter = new DSASignatureFormatter(DSAC);
            DSAFormatter.SetHashAlgorithm("SHA1");
            SHA1Managed SHhash = new SHA1Managed();
            byte[] SignedHashValue = DSAFormatter.CreateSignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxplaintext.Text)));
            textboxsigned.Text = Convert.ToBase64String(SignedHashValue);
        }


        private void BtnVerify_Click(object sender, EventArgs e)
        {
                DSASignatureDeformatter DSADeformatter = new DSASignatureDeformatter(DSAC);
                DSADeformatter.SetHashAlgorithm("SHA1");
                SHA1Managed SHhash = new SHA1Managed();
                if (DSADeformatter.VerifySignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxplaintext.Text)),
                Convert.FromBase64String(textboxsigned.Text))           
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
