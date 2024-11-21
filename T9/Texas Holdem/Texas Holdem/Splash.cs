using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Texas_Holdem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            Init_Screen init1 = new Init_Screen();
            this.Hide();
            timer1.Show();
            

        }
    }
}