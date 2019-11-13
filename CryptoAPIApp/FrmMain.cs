using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

        }

        static FrmMain _obj;
        
 
        public static FrmMain Instance

        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmMain();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return panelContainer;
            }

            set
            {
                panelContainer = value;
            }
        }

        public Button Button3
        {
            get
            {
                return button3;
            }

            set
            {
                button3 = value;
            }
        }

        public Button Button8
        {
            get
            {
                return button8;
            }

            set
            {
                button8 = value;
            }
        }
        public Panel Sidepanel1
        {
            get
            {
                return Sidepanel;
            }

            set
            {
                Sidepanel = value;
            }
        }



        public void StartForm()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;

            UserControlHome uch = new UserControlHome();
            uch.Dock = DockStyle.Fill;
            
            panelContainer.Controls.Add(uch);
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            userControlHome1.BringToFront();         
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;
            userControlGeneral1.BringToFront();
        }


        private void Button8_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button8.Height;
            Sidepanel.Top = button8.Top;
            userControlAlgorithms1.BringToFront();
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/fidan-sinani-014284171/");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fid9");
        }

      
    }
}

