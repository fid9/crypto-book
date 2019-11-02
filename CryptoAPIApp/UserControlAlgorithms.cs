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
    public partial class UserControlAlgorithms : UserControl
    {
        public UserControlAlgorithms()
        {
            InitializeComponent();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlMD5"))
                {
                    UserControlMD5 ucal = new UserControlMD5();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlMD5"].BringToFront();
            }
            else if (metroComboBox1.SelectedIndex == 1)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlSHA1"))
                {
                    UserControlSHA1 ucal = new UserControlSHA1();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlSHA1"].BringToFront();
            }
            else if (metroComboBox1.SelectedIndex == 2)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlSHA256"))
                {
                    UserControlSHA256 ucal = new UserControlSHA256();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlSHA256"].BringToFront();
            }
            else if (metroComboBox1.SelectedIndex == 3)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlSHA384"))
                {
                    UserControlSHA384 ucal = new UserControlSHA384();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlSHA384"].BringToFront();
            }
            else if (metroComboBox1.SelectedIndex == 4)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlSHA512"))
                {
                    UserControlSHA512 ucal = new UserControlSHA512();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlSHA512"].BringToFront();
            }
            else if (metroComboBox1.SelectedIndex == 5)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlRIPEMD160"))
                {
                    UserControlRIPEMD160 ucal = new UserControlRIPEMD160();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlRIPEMD160"].BringToFront();
            }
            else
            {
                MessageBox.Show("Please select an algorithm!");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (metroComboBox2.SelectedIndex == 0)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlCaesar"))
                {
                    UserControlCaesar ucal = new UserControlCaesar();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlCaesar"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 1)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlPlayfair"))
                {
                    UserControlPlayfair ucal = new UserControlPlayfair();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlPlayfair"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 2)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControl1TP"))
                {
                    UserControl1TP ucal = new UserControl1TP();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControl1TP"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 3)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlVigenere"))
                {
                    UserControlVigenere ucal = new UserControlVigenere();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlVigenere"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 4)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlAES"))
                {
                    UserControlAES ucal = new UserControlAES();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlAES"].BringToFront();
            }
            
            else if (metroComboBox2.SelectedIndex == 5)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlDES"))
                {
                    UserControlDES ucal = new UserControlDES();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlDES"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 6)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControl3DES"))
                {
                    UserControl3DES ucal = new UserControl3DES();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControl3DES"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 7)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlIDEA"))
                {
                    UserControlIDEA ucal = new UserControlIDEA();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlIDEA"].BringToFront();
            }
            else if (metroComboBox2.SelectedIndex == 8)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlRSA"))
                {
                    UserControlRSA ucal = new UserControlRSA();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlRSA"].BringToFront();
            }
            else
            {
                MessageBox.Show("Please select an algorithm!");
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (metroComboBox3.SelectedIndex == 0)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlRSAS"))
                {
                    UserControlRSAS ucal = new UserControlRSAS();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlRSAS"].BringToFront();
            }
            else if (metroComboBox3.SelectedIndex == 1)
            {
                if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlDSAS"))
                {
                    UserControlDSAS ucal = new UserControlDSAS();
                    ucal.Dock = DockStyle.Fill;
                    FrmMain.Instance.PnlContainer.Controls.Add(ucal);
                }

                FrmMain.Instance.PnlContainer.Controls["UserControlDSAS"].BringToFront();
            }
            else
            {
                MessageBox.Show("Please select an algorithm!");
            }
        }
    }
}
