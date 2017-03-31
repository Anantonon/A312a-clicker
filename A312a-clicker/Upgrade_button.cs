using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace A312a_clicker
{
    class Upgrade_button : Button
    {
        /* Det meste i denne klasse er kopieret fra Thomas' calculator eksempel,
         * så har ikke rigtigt nogen idé om, hvordan det fungerer (endnu).
         * Pointen er, at man skal kunne oprette upgrade_buttons dynamisk,
         * med billede, person at opgradere og hvor meget de skal opgraderes med */


        public delegate void UpgradeClickEventHandler(Upgrade_button sender, int number);

        public event UpgradeClickEventHandler UpgradeClick;

        public Upgrade_button() {}

        public Upgrade_button(string image_filepath, string person_to_upgrade, double upgrade_to_wpm)
        {
            UseVisualStyleBackColor = true;
            Size = new Size(27, 27);
            Image = Image.FromFile(image_filepath);
            Click += Upgrade_button_click;
            this.person_to_upgrade = person_to_upgrade;
            this.upgrade_to_wpm = upgrade_to_wpm;
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text { get; set; }

        string person_to_upgrade;
        double upgrade_to_wpm;

        void Upgrade_button_click(object sender, EventArgs e)
        {
            
        }
    }
}
