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
    public partial class UserControlVigenere : UserControl
    {
        public UserControlVigenere()
        {   
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            String str = textboxplaintext.Text.ToString();
            String key = textboxkey.Text.ToString();

            Invoke(new Action(() => textboxencrypted.Clear()));
            Invoke(new Action(() => textboxencrypted.AppendText(VigenereEnc(str.ToUpper(), key.ToUpper()))));
            
        }

        public static string VigenereEnc(string pt, string key)
        {
            string ct = "";
            try
            {
                char[] keys = key.ToCharArray();
                int j = 0;
                foreach (char c in pt)
                {
                    int k = c - 65;
                    int y = keys[j] - 65;

                    ct += (char)((k + y) % 26 + 65);

                    j = (j + 1) % key.Length;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ct;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String str = textboxencrypted.Text.ToString();
            String key = textboxkey.Text.ToString();



            Invoke(new Action(() => textboxdecrypted.Clear()));
            Invoke(new Action(() => textboxdecrypted.AppendText(VigenereDec(str.ToUpper(), key.ToUpper()))));
        }

        public static string VigenereDec(string pt, string key)
        {
            string ct = "";
            try
            {
                
                char[] keys = key.ToCharArray();
                int j = 0;
                foreach (char c in pt)
                {
                    int k = c - 65;
                    int y = keys[j] - 65;
                    if (k >= y)
                        ct += (char)((k - y) % 26 + 65);
                    else
                        ct += (char)((k - y + 26) % 26 + 65);
                    j = (j + 1) % key.Length;

                }
   
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ct;
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
