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
    
        DateTime nejstarsi(DateTime Narozen1, DateTime Narozen2, DateTime Narozen3)
        {
            DateTime nej = Narozen1;
            if (Narozen2 < nej) nej = Narozen2;
            if (Narozen3 < nej) nej = Narozen3;
            return nej;
        }


        DateTime Metoda1(DateTime datum, int pocetDnu) //Zjistíme datum za zadaný počet dnů
        {
            return datum.AddDays(pocetDnu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Narozen1 = DateTime.Parse(textBox1.Text);
            DateTime Narozen2 = DateTime.Parse(textBox2.Text);
            DateTime Narozen3 = DateTime.Parse(textBox3.Text);
            DateTime nej = Narozen1;
            
            MessageBox.Show("Nejstarsi ze tri je: " + nej.ToString("dddd d. MM. yyyy"));


            //Metoda1
            DateTime dnes = DateTime.Today;
            int x = int.Parse(textBox4.Text);

            MessageBox.Show("Datum po uplynutí " + x + " dnů bude: " + Metoda1(dnes, x).ToShortDateString());


            //Fekimu to funguje bez problemu tato metoda. 
            //A ja jsem spatne pochopil zadání.
        }
    }
}
