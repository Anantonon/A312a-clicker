namespace A312a_clicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ord_skrevet_viser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.projekt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.anton_count = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.anton_pris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ord_skrevet_viser
            // 
            this.ord_skrevet_viser.AutoSize = true;
            this.ord_skrevet_viser.Location = new System.Drawing.Point(706, 443);
            this.ord_skrevet_viser.Name = "ord_skrevet_viser";
            this.ord_skrevet_viser.Size = new System.Drawing.Size(74, 13);
            this.ord_skrevet_viser.TabIndex = 1;
            this.ord_skrevet_viser.Text = "Ord skrevet: 0";
            this.ord_skrevet_viser.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::A312a_clicker.Properties.Resources.Anton1;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 229);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projekt
            // 
            this.projekt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.projekt.Image = global::A312a_clicker.Properties.Resources.sharelatex;
            this.projekt.Location = new System.Drawing.Point(584, 277);
            this.projekt.Name = "projekt";
            this.projekt.Size = new System.Drawing.Size(129, 163);
            this.projekt.TabIndex = 0;
            this.projekt.UseVisualStyleBackColor = true;
            this.projekt.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // anton_count
            // 
            this.anton_count.AutoSize = true;
            this.anton_count.Location = new System.Drawing.Point(77, 257);
            this.anton_count.Name = "anton_count";
            this.anton_count.Size = new System.Drawing.Size(56, 13);
            this.anton_count.TabIndex = 3;
            this.anton_count.Text = "Antoner: 0";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 447);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Gem spil";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // anton_pris
            // 
            this.anton_pris.AutoSize = true;
            this.anton_pris.Location = new System.Drawing.Point(87, 244);
            this.anton_pris.Name = "anton_pris";
            this.anton_pris.Size = new System.Drawing.Size(36, 13);
            this.anton_pris.TabIndex = 5;
            this.anton_pris.Text = "Pris: 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 482);
            this.Controls.Add(this.anton_pris);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.anton_count);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ord_skrevet_viser);
            this.Controls.Add(this.projekt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button projekt;
        private System.Windows.Forms.Label ord_skrevet_viser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label anton_count;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label anton_pris;
    }
}

