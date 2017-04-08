﻿using System;
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

        public bool Upgrade1_true;
        public abstract void Upgrade();
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
            _price_label.Text = $"Price: {Price()}";
            _count_label.Text = $"{Name}s: {Number}";
            _words_s_label.Text = $"Words/s: {Income()}";
        }

    }
}
