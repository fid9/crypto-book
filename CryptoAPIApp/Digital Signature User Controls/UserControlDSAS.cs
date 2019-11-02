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
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (textboxplaintext.Text == "") return;
            DSACryptoServiceProvider DSA = new DSACryptoServiceProvider();
            DSASignatureFormatter DSAFormatter = new DSASignatureFormatter(DSA);
            DSAFormatter.SetHashAlgorithm("SHA1");
            SHA1Managed SHhash = new SHA1Managed();
            byte[] SignedHashValue = DSAFormatter.CreateSignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxplaintext.Text)));
            textboxsigned.Text = Convert.ToBase64String(SignedHashValue);
        }


        private void BtnVerify_Click(object sender, EventArgs e)
        {
                DSACryptoServiceProvider DSA = new DSACryptoServiceProvider();
                DSASignatureDeformatter DSADeformatter = new DSASignatureDeformatter(DSA);
                DSADeformatter.SetHashAlgorithm("SHA1");
                SHA1Managed SHhash = new SHA1Managed();
                if (DSADeformatter.VerifySignature(SHhash.ComputeHash(new UnicodeEncoding().GetBytes(textboxsigned.Text)),
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
