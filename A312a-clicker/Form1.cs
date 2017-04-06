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

        UInt64 words_written = 0;
        int _typedWords = 0;
        Anton anton = new Anton();
        Lasse lasse = new Lasse();
        Casper casper = new Casper();
        Mads mads = new Mads();
        Ezzi ezzi = new Ezzi();
        Thue thue = new Thue();
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void Projekt_Click(object sender, EventArgs e)
        {

        }
        
        void Typing(object sender, KeyPressEventArgs e)
        {
            if (_typedWords < 5)
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
                words_written += (UInt64)(2 * anton.Number);
            }
            if (lasse.Number > 0)
            {
                words_written += (UInt64)(100 * lasse.Number);
            }
            if (casper.Number > 0)
            {
                words_written += (UInt64)(5000 * casper.Number);
            }
            if (mads.Number > 0)
            {
                words_written += (UInt64)(800000 * mads.Number);
            }
            if (ezzi.Number > 0)
            {
                words_written += (UInt64)(1000000 * ezzi.Number);
            }
            if (thue.Number > 0)
            {
                words_written += (UInt64)(999999999 * thue.Number);
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
                words_written -= (UInt64)(lasse.Price());
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
                words_written -= (UInt64)(anton.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++anton.Number;
                anton_count.Text = $"Antons: {anton.Number}";
                anton_price.Text = $"Price: {anton.Price()}";
            }
        }


        private void button_casper_Click(object sender, EventArgs e)
        {
            if (words_written >= casper.Price())
            {
                words_written -= (UInt64)(casper.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++casper.Number;
                casper_count.Text = $"Caspers: {casper.Number}";
                casper_price.Text = $"Price: {casper.Price()}";
            }
        }



        private void button_mads_Click(object sender, EventArgs e)
        {
            if (words_written >= mads.Price())
            {
                words_written -= (UInt64)(mads.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++mads.Number;
                mads_count.Text = $"Madss: {mads.Number}";
                mads_price.Text = $"Price: {mads.Price()}";
            }
        }

        private void button_ezzi_Click(object sender, EventArgs e)
        {
            if (words_written >= ezzi.Price())
            {
                words_written -= (UInt64)(ezzi.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++ezzi.Number;
                ezzi_count.Text = $"Ezzis: {ezzi.Number}";
                ezzi_price.Text = $"Price: {ezzi.Price()}";
            }
        }

        private void button_thue_Click(object sender, EventArgs e)
        {
            if (words_written >= thue.Price())
            {
                words_written -= (UInt64)(thue.Price());
                words_written_counter.Text = $"Words written: {words_written}";
                ++thue.Number;
                ezzi_count.Text = $"Thues: {thue.Number}";
                ezzi_price.Text = $"Price: {thue.Price()}";
            }
        }





        private void lasse_price_Click(object sender, EventArgs e)
        {

        }

        private void cheat_button_Click(object sender, EventArgs e)
        {
            words_written += 100000000;
            words_written_counter.Text = $"Words written: {words_written}";

        }
    }
}
