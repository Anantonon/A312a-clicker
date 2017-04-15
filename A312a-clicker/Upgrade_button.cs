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
        /* When created, the upgrade_button will get an image from the filepath, 
         * it will know which person to upgrade,
         * and it has access to the array of all people, so that it can call their methods*/
        public Upgrade_button(string image_filepath, int person_to_upgrade, ref Person[] AllPeople, Point Location, string TooltipText)
        {
            UseVisualStyleBackColor = true;
            Size = new Size(180, 80);
            Image = Image.FromFile($@"{image_filepath}");
            Click += Upgrade_button_click;
            this.person_to_upgrade = person_to_upgrade;
            this.AllPeople = AllPeople;
            this.Location = Location;
            /* Generates a tooltip, with a description for the upgrade */
            Tooltip = new ToolTip();
            Tooltip.SetToolTip(this, TooltipText);
            Tooltip.InitialDelay = 1;
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text { get; set; }

        int person_to_upgrade;
        Person[] AllPeople;
        ToolTip Tooltip;

        void Upgrade_button_click(object sender, EventArgs e)
        {
            AllPeople[person_to_upgrade].Upgrade();
            Parent.Controls.Remove(this);
        }
    }
}
