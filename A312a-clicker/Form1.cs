using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000; //Starter timeren, der tæller words up hvert sekund

        }

        int words_written = 0;
        Anton anton = new Anton();



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Projekt_Click(object sender, EventArgs e)
        {
            ++words_written;
            words_written_counter.Text = $"Words written: {words_written}";

        }

        private void Anton_Click(object sender, EventArgs e)
        {
            
            if (words_written >= anton.Price())
            {
                words_written -= (int)(anton.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++anton.Number;
                anton_count.Text = $"Antons: {anton.Number}";
                anton_price.Text = $"Price: {anton.Price()}";


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (anton.Number > 0)
            {
                words_written += 2* anton.Number;
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Save.SaveGame(words_written.ToString(), anton.Number.ToString());
        }
    }
}
