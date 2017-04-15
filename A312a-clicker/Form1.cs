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
            this.KeyPress +=
               new KeyPressEventHandler(Typing);

            AllPeople[0] = new Anton("Anton", anton_price, anton_count, anton__words_s);
            AllPeople[1] = new Lasse("Lasse", lasse_price, lasse_count, lasse_words_s);
            AllPeople[2] = new Casper("Casper", casper_price, casper_count, casper_words_s);
            AllPeople[3] = new Mads("Mads", mads_price, mads_count, mads_words_s);
            AllPeople[4] = new Ezzi("Ezzi", ezzi_price, ezzi_count, ezzi_words_s);
            AllPeople[5] = new Thue("Thue", thue_price, thue_count, thue_words_s);
            events = new Event(ref AllPeople);
        }

        UInt64 words_written = 0;
        string words_written_string;
        UInt64 words_s = 0;
        string words_s_string;
        int _typedWords = 0;
        public Person[] AllPeople = new Person[6];
        Event events;
        public static bool ConvertToPrettyNumbers = true;

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
                RefreshWords();
            }
        }

        void RefreshWords()
        {
            words_written_string = words_written.ToString();
            if (ConvertToPrettyNumbers)
            {
                words_written_string = NumberConvert.ConvertIt(words_written);
            }
            words_written_counter.Text = $"Words written: {words_written_string}";

        }

        void RefreshWordsSecond()
        {
            words_s = 0;
            for (int i = 0; i < 6; ++i)
            {
                if (AllPeople[i].Number > 0)
                {
                    words_s += (UInt64)(AllPeople[i].Income());
                }
            }
            words_s_string = words_s.ToString();
            if (ConvertToPrettyNumbers)
            {
                words_s_string = NumberConvert.ConvertIt(words_s);
            }
            words_s_total.Text = $"Words/s: {words_s_string}";

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
            RefreshWords();
            
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
            RefreshWords();

            for (int i = 1; i < 7; ++i)
            {
                AllPeople[i-1].Number = Convert.ToInt64(savegame[i]);
                AllPeople[i-1].Refresh();
            }
            Save.SaveOrLoadSuccessful(false);
        }
        /* TO-DO: All these Click methods are similar. Maybe make them all call a single method instead? */
        private void Anton_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[0].Price())
            {
                words_written -= (UInt64)(AllPeople[0].Price());
                AllPeople[0].Purchase();
                if (AllPeople[0].Number == 5)
                {
                    UpgradeCreater("anton_upgrade_1.png", 0, AllPeople[0].Upgrade1Tooltip);
                    AllPeople[0].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }

        private void Lasse_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[1].Price())
            {
                words_written -= (UInt64)(AllPeople[1].Price());
                AllPeople[1].Purchase();
                if (AllPeople[1].Number == 5)
                {
                    UpgradeCreater("lasse1.png", 1, "");
                    AllPeople[1].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }
        

        private void button_casper_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[2].Price())
            {
                words_written -= (UInt64)(AllPeople[2].Price());
                AllPeople[2].Purchase();
                if (AllPeople[2].Number == 5)
                {
                    UpgradeCreater("casper1.png", 2, "");
                    AllPeople[2].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }

        private void button_mads_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[3].Price())
            {
                words_written -= (UInt64)(AllPeople[3].Price());
                AllPeople[3].Purchase();
                if (AllPeople[3].Number == 5)
                {
                    UpgradeCreater("mads.png", 3, "");
                    AllPeople[3].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }

        private void button_ezzi_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[4].Price())
            {
                words_written -= (UInt64)(AllPeople[4].Price());
                AllPeople[4].Purchase();
                if (AllPeople[4].Number == 5)
                {
                    UpgradeCreater("ezzi.png", 4, "");
                    AllPeople[4].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }

        private void button_thue_Click(object sender, EventArgs e)
        {
            if (words_written >= AllPeople[5].Price())
            {
                words_written -= (UInt64)(AllPeople[5].Price());
                AllPeople[5].Purchase();
                if (AllPeople[5].Number == 5)
                {
                    UpgradeCreater("thue.png", 5, "");
                    AllPeople[5].Upgrade1_true = true;
                }
                RefreshWordsSecond();
                RefreshWords();
            }
        }

        
        private void cheat_button_Click(object sender, EventArgs e)
        {
            words_written += 1000000000000000000;
            RefreshWords();
        }

        int xcoordinate = 0;
        int ycoordinate = 0;
        private void UpgradeCreater(string image_path, int person_to_upgrade, string UpgradeTooltip)
        {
           
            /* The files are in \Source\Repos\A312a-clicker\A312a-clicker\bin\Debug, so cannot find file in resource folder yet */
            
            if (xcoordinate < 560) {
                Upgrade_button upgrade_button = (new Upgrade_button(image_path, person_to_upgrade, ref AllPeople, new Point(xcoordinate, ycoordinate), UpgradeTooltip));
                upgrade_panel.Controls.Add(upgrade_button);
                upgrade_button.Click += Upgrade_button_Click;
                xcoordinate += 190;
            }
            else
            {
                xcoordinate = 0;
                ycoordinate += 90;
                Upgrade_button upgrade_button = (new Upgrade_button(image_path, person_to_upgrade, ref AllPeople, new Point(xcoordinate, ycoordinate), UpgradeTooltip));
                upgrade_panel.Controls.Add(upgrade_button);
                upgrade_button.Click += Upgrade_button_Click;
                xcoordinate += 190;
            }
        }

        private void Upgrade_button_Click(object sender, EventArgs e)
        {
            RefreshWordsSecond();
            xcoordinate = 0;
            ycoordinate = 0;
            foreach (Upgrade_button button in upgrade_panel.Controls)
            {
                if (xcoordinate < 560)
                {
                    button.Location = (new Point(xcoordinate, ycoordinate));
                    xcoordinate += 190;
                }
                else
                {
                    xcoordinate = 0;
                    ycoordinate += 90;
                    button.Location = (new Point(xcoordinate, ycoordinate));
                    xcoordinate += 190;
                }
            }
        }

        private void pretty_numbers_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToPrettyNumbers = pretty_numbers_checkbox.Checked;
            RefreshWords();
            for(int i = 0; i <= 5; ++i)
            {
                AllPeople[i].Refresh();
            }
        }

        Random random = new Random();
        //Calls a random event every 5 minutes
        private void EventTimer_Tick(object sender, EventArgs e)
        {
           /* if (events.Change)
            {
                events.Reset();
                events.Change = false;
            }

            if(random.Next(0,2) == 0)
            {
                events.Events[random.Next(0, events.Events.Count)]();
                events.Change = true;
            }*/
        }
    }
}
