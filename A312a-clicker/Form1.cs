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

            anton  = new Anton("Anton", anton_price, anton_count, anton__words_s);
            lasse  = new Lasse("Lasse", lasse_price, lasse_count, lasse_words_s);
            casper = new Casper("Casper", casper_price, casper_count, casper_words_s);
            mads   = new Mads("Mads", mads_price, mads_count, mads_words_s);
            ezzi   = new Ezzi("Ezzi", ezzi_price, ezzi_count, ezzi_words_s);
            thue   = new Thue("Thue", thue_price, thue_count, thue_words_s);
        }

        UInt64 words_written = 0;
        int _typedWords = 0;
        Anton anton;
        Lasse lasse;
        Casper casper;
        Mads mads;
        Ezzi ezzi;
        Thue thue;
        
        

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
                words_written += (UInt64)(anton.Income());
            }
            if (lasse.Number > 0)
            {
                words_written += (UInt64)(lasse.Income());
            }
            if (casper.Number > 0)
            {
                words_written += (UInt64)(casper.Income());
            }
            if (mads.Number > 0)
            {
                words_written += (UInt64)(mads.Income());
            }
            if (ezzi.Number > 0)
            {
                words_written += (UInt64)(ezzi.Income());
            }
            if (thue.Number > 0)
            {
                words_written += (UInt64)(thue.Income());
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
                lasse.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }
        private void Anton_Click(object sender, EventArgs e)
        {
            if (words_written >= anton.Price())
            {
                words_written -= (UInt64)(anton.Price());
                anton.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }


        private void button_casper_Click(object sender, EventArgs e)
        {
            if (words_written >= casper.Price())
            {
                words_written -= (UInt64)(casper.Price());
                casper.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }



        private void button_mads_Click(object sender, EventArgs e)
        {
            if (words_written >= mads.Price())
            {
                words_written -= (UInt64)(mads.Price());
                mads.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";

            }
        }

        private void button_ezzi_Click(object sender, EventArgs e)
        {
            if (words_written >= ezzi.Price())
            {
                words_written -= (UInt64)(ezzi.Price());
                ezzi.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void button_thue_Click(object sender, EventArgs e)
        {
            if (words_written >= thue.Price())
            {
                words_written -= (UInt64)(thue.Price());
                thue.Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
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
