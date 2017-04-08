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

            AllPeople[0] = new Anton("Anton", anton_price, anton_count, anton__words_s);
            AllPeople[1] = new Lasse("Lasse", lasse_price, lasse_count, lasse_words_s);
            AllPeople[2] = new Casper("Casper", casper_price, casper_count, casper_words_s);
            AllPeople[3] = new Mads("Mads", mads_price, mads_count, mads_words_s);
            AllPeople[4] = new Ezzi("Ezzi", ezzi_price, ezzi_count, ezzi_words_s);
            AllPeople[5] = new Thue("Thue", thue_price, thue_count, thue_words_s);
        }

        UInt64 words_written = 0;
        int _typedWords = 0;
        Person[] AllPeople = new Person[6];

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
            for(int i = 0; i < 6; ++i)
            {
                if(AllPeople[i].Number > 0)
                {
                    words_written += (UInt64)(AllPeople[i].Income());
                }
            }
            words_written_counter.Text = $"Words written: {words_written}";
            
        }

        /* Saves words first, then the for loop saves all people */
        private void save_button_Click(object sender, EventArgs e)
        {
            string[] AllPeopleSave = new string[7];

            AllPeopleSave[0] = words_written.ToString();

            for (int i = 1; i < 7; ++i)
            {
                AllPeopleSave[i] = AllPeople[i-1].Number.ToString();
            }

            Save.SaveGame(AllPeopleSave);
            Save.SaveOrLoadSuccessful(true);
        }
        
        /*Loads words first, then the for loop loads all people*/
        private void load_button_Click(object sender, EventArgs e)
        {
            string[] savegame = Save.LoadGame();

            words_written = Convert.ToUInt64(savegame[0]);
            words_written_counter.Text = $"Words written: {words_written}";

            for (int i = 1; i < 7; ++i)
            {
                AllPeople[i-1].Number = Convert.ToInt64(savegame[i]);
                AllPeople[i-1].Refresh();
            }
            Save.SaveOrLoadSuccessful(false);
        }

        private void Anton_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[0].Price())
            {
                words_written -= (UInt64)(AllPeople[0].Price());
                AllPeople[0].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void Lasse_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[1].Price())
            {
                words_written -= (UInt64)(AllPeople[1].Price());
                AllPeople[1].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }
        

        private void button_casper_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[2].Price())
            {
                words_written -= (UInt64)(AllPeople[2].Price());
                AllPeople[2].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void button_mads_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[3].Price())
            {
                words_written -= (UInt64)(AllPeople[3].Price());
                AllPeople[3].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void button_ezzi_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[4].Price())
            {
                words_written -= (UInt64)(AllPeople[4].Price());
                AllPeople[4].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void button_thue_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[5].Price())
            {
                words_written -= (UInt64)(AllPeople[5].Price());
                AllPeople[5].Purchase();
                words_written_counter.Text = $"Words written: {words_written}";
            }
        }

        private void cheat_button_Click(object sender, EventArgs e)
        {
            words_written += 1000000000000000000;
            words_written_counter.Text = $"Words written: {words_written}";
        }
    }
}
