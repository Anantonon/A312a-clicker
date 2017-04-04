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
            timer1.Interval = 1000; //Starts timer, that adds words/second to words_written
            this.KeyPress +=
               new KeyPressEventHandler(Typing);
        }

        int words_written = 0;
        int _typedWords = 0;
        Anton anton = new Anton();
        Lasse lasse = new Lasse();



        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void Projekt_Click(object sender, EventArgs e)
        {
            /*
            ++words_written;
            words_written_counter.Text = $"Words written: {words_written}";
            */
        }
        
        void Typing(object sender, KeyPressEventArgs e)
        {
            if (_typedWords < 10)
            {
                ++_typedWords;
            }
            else
            {
                _typedWords = 1;
                ++words_written;
                words_written_counter.Text = $"Words written: {words_written}";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (anton.Number > 0)
            {
                words_written += 2 * anton.Number;
            }
            if (lasse.Number > 0)
            {
                words_written += 100 * lasse.Number;
            }
            words_written_counter.Text = $"Words written: {words_written}";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Save.SaveGame(words_written.ToString(), anton.Number.ToString());
        }

        private void Lasse_Click(object sender, EventArgs e)
        {
            if (words_written >= lasse.Price())
            {
                words_written -= (int)(lasse.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++lasse.Number;
                lasse_count.Text = $"Lasses: {lasse.Number}";
                lasse_price.Text = $"Price: {lasse.Price()}";
            }
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
    }
}
