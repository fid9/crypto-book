using System;

using System.Text;

using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class UserControl1TP : UserControl
    {
        public UserControl1TP()
        {
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => textboxencrypted.Clear()));
            byte[] originalBytes = Encoding.Unicode.GetBytes(textboxplaintext.Text);
            byte[] pad = GeneratePad(size: originalBytes.Length, seed: 1);
            textboxkey.Text = Convert.ToBase64String(inArray: pad);
            byte[] encrypted = Encrypt(originalBytes, pad);
            textboxencrypted.Text = Convert.ToBase64String(inArray: encrypted);
        }

        public static byte[] GeneratePad(int size, int seed)
        {
            var random = new Random(Seed: seed);
            var bytesBuffel = new byte[size];

            random.NextBytes(bytesBuffel);

            return bytesBuffel;
        }
        
        public static byte[] Encrypt(byte[] data, byte[] pad)
        {
            var result = new byte[data.Length];
            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    var sum = (int)data[i] + (int)pad[i];
                    if (sum > 255)
                        sum -= 255;
                    result[i] = (byte)sum;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => textboxdecrypted.Clear()));
            byte[] encryptedFromBase64 = Convert.FromBase64String(textboxencrypted.Text);
            byte[] originalBytes = Encoding.Unicode.GetBytes(textboxencrypted.Text);
            byte[] pad = GeneratePad(size: originalBytes.Length, seed: 1);
            byte[] decrypted = Decrypt(encryptedFromBase64, pad);

            textboxdecrypted.Text = Encoding.Unicode.GetString(decrypted);
        }

        public static byte[] Decrypt(byte[] encrypted, byte[] pad)
        {
            var result = new byte[encrypted.Length];
            try
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    var dif = (int)encrypted[i] - (int)pad[i];
                    if (dif < 0)
                        dif += 255;
                    result[i] = (byte)dif;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
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
