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

namespace CryptoAPIApp
{
    public partial class UserControlIDEA : UserControl
    {
        public UserControlIDEA()
        {
            InitializeComponent();
        }

        private String tempInputFilename = "tempPlainText.txt";
        private String tempOutputFilename = "tempEncryptedData.dat";
        private void BtnHash_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textboxplaintext.Text))
                {
                    MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(textboxkey.Text))
                {
                    MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.WriteAllText(tempInputFilename, textboxplaintext.Text);
                    IdeaCrypt.cryptFile(tempInputFilename, tempOutputFilename, textboxkey.Text, true);
                    textboxencrypted.Text = String.Join(" ", File.ReadAllBytes(tempOutputFilename));
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
                if (string.IsNullOrWhiteSpace(textboxencrypted.Text))
                {
                    MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(textboxkey.Text))
                {
                    MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String[] values = textboxencrypted.Text.Split(' ');
                    byte[] bytes = new byte[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        bytes[i] = Byte.Parse(values[i]);
                    }
                    File.WriteAllBytes(tempOutputFilename, bytes);
                    try
                    {
                        IdeaCrypt.cryptFile(tempOutputFilename, tempInputFilename, textboxkey.Text, false);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    textboxdecrypted.Text = File.ReadAllText(tempInputFilename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void UserControlIDEA_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Textboxkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textboxplaintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
