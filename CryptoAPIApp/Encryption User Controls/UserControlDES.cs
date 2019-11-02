using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CryptoAPIApp
{
    public partial class UserControlDES : UserControl
    {
        public UserControlDES()
        {
            InitializeComponent();
            desobj = DES.Create();
        }

        string cipherdata;
        byte[] cipherbytes;
        byte[] plainbytes;
        byte[] plainbytes2;
        byte[] plainkey;

        SymmetricAlgorithm desobj;

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
              if (textboxplaintext.Text == "") return;
                cipherdata = textboxplaintext.Text;
                plainbytes = Encoding.UTF8.GetBytes(cipherdata);
                plainkey = Encoding.UTF8.GetBytes("0123abcd");
                desobj.Key = plainkey;

                desobj.Mode = CipherMode.CBC;
                desobj.Padding = PaddingMode.PKCS7;
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, desobj.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(plainbytes, 0, plainbytes.Length);
                cs.Close();
                cipherbytes = ms.ToArray();
                ms.Close();
                textboxencrypted.Text = Encoding.UTF8.GetString(cipherbytes);
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {


                MemoryStream ms1 = new MemoryStream(cipherbytes);
                CryptoStream cs1 = new CryptoStream(ms1, desobj.CreateDecryptor(), CryptoStreamMode.Read);
                cs1.Read(cipherbytes, 0, cipherbytes.Length);
                plainbytes2 = ms1.ToArray();
                cs1.Close();
                ms1.Close();
                textboxdecrypted.Text = Encoding.UTF8.GetString(plainbytes2);
            }


            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Textboxplaintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Textboxencrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
