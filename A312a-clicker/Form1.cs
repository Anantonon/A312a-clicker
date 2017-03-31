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
            timer1.Interval = 1000;
        }

        int ord_skrevet = 0;
        int anton_writer = 0;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++ord_skrevet;
            ord_skrevet_viser.Text = $"Ord skrevet: {ord_skrevet}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ord_skrevet >= 1.6*(2 * anton_writer))
            {
                ord_skrevet -= (int)(1.6 * (2 * anton_writer));
                ord_skrevet_viser.Text = $"Ord skrevet: {ord_skrevet}";
                ++anton_writer;
                anton_count.Text = $"Antoner: {anton_writer}";
                anton_pris.Text = $"Pris: {1.6 * (2 * anton_writer)}";


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (anton_writer > 0)
            {
                ord_skrevet += 2*anton_writer;
                ord_skrevet_viser.Text = $"Ord skrevet: {ord_skrevet}";
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Save.SaveGame(ord_skrevet.ToString(), anton_writer.ToString());
        }
    }
}
