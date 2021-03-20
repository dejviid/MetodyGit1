using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Narozen1 = DateTime.Parse(textBox1.Text);
            DateTime Narozen2 = DateTime.Parse(textBox2.Text);
            DateTime Narozen3 = DateTime.Parse(textBox3.Text);
            DateTime Nejstarsi = Narozen1;

            if(Narozen2<Nejstarsi)  Nejstarsi = Narozen2;
            if (Narozen3 < Nejstarsi) Nejstarsi = Narozen3;
            MessageBox.Show("Nejstarsi ze tri je: " + Nejstarsi.ToString("dd MM yyy"));
            
        }
    }
}
