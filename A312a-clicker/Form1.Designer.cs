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
            this.words_written_counter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.anton_count = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.anton_price = new System.Windows.Forms.Label();
            this.upgrade_panel = new System.Windows.Forms.Panel();
            this.button_lasse = new System.Windows.Forms.Button();
            this.button_anton = new System.Windows.Forms.Button();
            this.button_projekt = new System.Windows.Forms.Button();
            this.lasse_price = new System.Windows.Forms.Label();
            this.lasse_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // words_written_counter
            // 
            this.words_written_counter.AutoSize = true;
            this.words_written_counter.Location = new System.Drawing.Point(609, 447);
            this.words_written_counter.Name = "words_written_counter";
            this.words_written_counter.Size = new System.Drawing.Size(84, 13);
            this.words_written_counter.TabIndex = 1;
            this.words_written_counter.Text = "Words written: 0";
            this.words_written_counter.Click += new System.EventHandler(this.label1_Click);
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
            this.anton_count.Size = new System.Drawing.Size(52, 13);
            this.anton_count.TabIndex = 3;
            this.anton_count.Text = "Antons: 0";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 447);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save game";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // anton_price
            // 
            this.anton_price.AutoSize = true;
            this.anton_price.Location = new System.Drawing.Point(87, 244);
            this.anton_price.Name = "anton_price";
            this.anton_price.Size = new System.Drawing.Size(43, 13);
            this.anton_price.TabIndex = 5;
            this.anton_price.Text = "Price: 2";
            // 
            // upgrade_panel
            // 
            this.upgrade_panel.Location = new System.Drawing.Point(12, 277);
            this.upgrade_panel.Name = "upgrade_panel";
            this.upgrade_panel.Size = new System.Drawing.Size(566, 163);
            this.upgrade_panel.TabIndex = 6;
            // 
            // button_lasse
            // 
            this.button_lasse.CausesValidation = false;
            this.button_lasse.Image = global::A312a_clicker.Properties.Resources.Lasse1;
            this.button_lasse.Location = new System.Drawing.Point(217, 12);
            this.button_lasse.Name = "button_lasse";
            this.button_lasse.Size = new System.Drawing.Size(178, 229);
            this.button_lasse.TabIndex = 7;
            this.button_lasse.UseVisualStyleBackColor = true;
            this.button_lasse.Click += new System.EventHandler(this.Lasse_Click);
            // 
            // button_anton
            // 
            this.button_anton.Image = global::A312a_clicker.Properties.Resources.Anton1;
            this.button_anton.Location = new System.Drawing.Point(12, 12);
            this.button_anton.Name = "button_anton";
            this.button_anton.Size = new System.Drawing.Size(178, 229);
            this.button_anton.TabIndex = 2;
            this.button_anton.UseVisualStyleBackColor = true;
            this.button_anton.Click += new System.EventHandler(this.Anton_Click);
            // 
            // button_projekt
            // 
            this.button_projekt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_projekt.Image = global::A312a_clicker.Properties.Resources.sharelatex;
            this.button_projekt.Location = new System.Drawing.Point(584, 277);
            this.button_projekt.Name = "button_projekt";
            this.button_projekt.Size = new System.Drawing.Size(129, 163);
            this.button_projekt.TabIndex = 0;
            this.button_projekt.UseVisualStyleBackColor = true;
            this.button_projekt.Click += new System.EventHandler(this.Projekt_Click);
            // 
            // lasse_price
            // 
            this.lasse_price.AutoSize = true;
            this.lasse_price.Location = new System.Drawing.Point(282, 244);
            this.lasse_price.Name = "lasse_price";
            this.lasse_price.Size = new System.Drawing.Size(61, 13);
            this.lasse_price.TabIndex = 8;
            this.lasse_price.Text = "Price: 1000";
            // 
            // lasse_count
            // 
            this.lasse_count.AutoSize = true;
            this.lasse_count.Location = new System.Drawing.Point(282, 261);
            this.lasse_count.Name = "lasse_count";
            this.lasse_count.Size = new System.Drawing.Size(52, 13);
            this.lasse_count.TabIndex = 9;
            this.lasse_count.Text = "Lasses: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 482);
            this.Controls.Add(this.lasse_count);
            this.Controls.Add(this.lasse_price);
            this.Controls.Add(this.button_lasse);
            this.Controls.Add(this.upgrade_panel);
            this.Controls.Add(this.anton_price);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.anton_count);
            this.Controls.Add(this.button_anton);
            this.Controls.Add(this.words_written_counter);
            this.Controls.Add(this.button_projekt);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_projekt;
        private System.Windows.Forms.Label words_written_counter;
        private System.Windows.Forms.Button button_anton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label anton_count;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label anton_price;
        private System.Windows.Forms.Panel upgrade_panel;
        private System.Windows.Forms.Button button_lasse;
        private System.Windows.Forms.Label lasse_price;
        private System.Windows.Forms.Label lasse_count;
    }
}

