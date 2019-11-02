using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        int move = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 3;

            if(panelSlide.Left > 280)
            {
                panelSlide.Left = 0;
            }

            if(panelSlide.Left < 0)
            {
                move = 4;
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
