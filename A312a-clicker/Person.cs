using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public abstract class Person
    {
        public Person(string Name, Label person_price,  Label person_count,  Label person_words_s)
        {
            this.Name = Name;
            _price_label = person_price;
            _count_label = person_count;
            _words_s_label = person_words_s;
        }

        private Label _price_label;
        private Label _count_label;
        private Label _words_s_label;

        public string Name;
        public long Number = 0;
        public long Words_second;


        /* Every person can have three unique upgrades */
        public bool Upgrade1_true;
        public abstract double Upgrade1();
        public string Upgrade1Tooltip;
        public bool Upgrade2_true;
        public abstract double Upgrade2();
        public string Upgrade2Tooltip;
        public bool Upgrade_3_true;
        public abstract double Upgrade3();
        public string Upgrade3Tooltip;

        /* TO-DO: Make the person determine if able to upgrade, not Form1*/
        public void Upgrade()
        {
            if (Upgrade1_true)
            {
                Upgrade_Factor *= Upgrade1();
                Upgrade1_true = false;
            }
            if (Upgrade2_true)
            {
                Upgrade_Factor *= Upgrade2();
                Upgrade2_true = false;
            }
            if (Upgrade_3_true)
            {
                Upgrade_Factor *= Upgrade3();
                Upgrade_3_true = false;
            }
            Refresh();
        }
        
        public double Upgrade_Factor = 1;

        public abstract double Price();

        public long Income()
        {
            return (long)(Words_second * Number * Upgrade_Factor);
        }
        public void Purchase()
        {
            ++Number;
            Refresh();
        }
        public void Refresh()
        {
            if (Form1.ConvertToPrettyNumbers)
            {
                _price_label.Text = $"Price: {NumberConvert.ConvertIt((ulong)Price())}";
                _count_label.Text = $"{Name}s: {Number}";
                _words_s_label.Text = $"Words/s: {NumberConvert.ConvertIt((ulong)Income())}";
            }
            else
            {
                _price_label.Text = $"Price: {Price()}";
                _count_label.Text = $"{Name}s: {Number}";
                _words_s_label.Text = $"Words/s: {Income()}";
            }
        }

    }
}
