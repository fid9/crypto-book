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
    public partial class UserControlCaesar : UserControl
    {
        public UserControlCaesar()
        {
            InitializeComponent();
            ClearControlsEncrypt();
            ClearControlsDecrypt();
        }

        private string output;
        public void ClearControlsEncrypt()
        {

            textboxencrypted.Text = "";
            textboxkey.Text = "";
            textboxplaintext.Text = "";
        }

        public void ClearControlsDecrypt()
        {
            textboxdecrypted.Text = "";
            textboxkey2.Text = "";
            textboxplaintext2.Text = "";
        }
        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControlsEncrypt();
        }

        private void BtnCipher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textboxkey.Text) && !string.IsNullOrEmpty(textboxplaintext.Text))
                {
                    output = Cipher.Encrypt(textboxplaintext.Text, int.Parse(textboxkey.Text));

                    textboxencrypted.Text = output;
                }

            }

             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(textboxkey2.Text) && !string.IsNullOrEmpty(textboxplaintext2.Text))
                {
                    output = Cipher.Decrypt(textboxplaintext2.Text, int.Parse(textboxkey2.Text));

                    textboxdecrypted.Text = output;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            ClearControlsDecrypt();
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
