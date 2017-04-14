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
            this.lasse_price = new System.Windows.Forms.Label();
            this.casper_price = new System.Windows.Forms.Label();
            this.lasse_count = new System.Windows.Forms.Label();
            this.casper_count = new System.Windows.Forms.Label();
            this.mads_price = new System.Windows.Forms.Label();
            this.mads_count = new System.Windows.Forms.Label();
            this.ezzi_price = new System.Windows.Forms.Label();
            this.ezzi_count = new System.Windows.Forms.Label();
            this.thue_price = new System.Windows.Forms.Label();
            this.thue_count = new System.Windows.Forms.Label();
            this.cheat_button = new System.Windows.Forms.Button();
            this.button_thue = new System.Windows.Forms.Button();
            this.button_ezzi = new System.Windows.Forms.Button();
            this.button_mads = new System.Windows.Forms.Button();
            this.button_casper = new System.Windows.Forms.Button();
            this.button_lasse = new System.Windows.Forms.Button();
            this.button_anton = new System.Windows.Forms.Button();
            this.anton__words_s = new System.Windows.Forms.Label();
            this.lasse_words_s = new System.Windows.Forms.Label();
            this.casper_words_s = new System.Windows.Forms.Label();
            this.mads_words_s = new System.Windows.Forms.Label();
            this.ezzi_words_s = new System.Windows.Forms.Label();
            this.thue_words_s = new System.Windows.Forms.Label();
            this.load_button = new System.Windows.Forms.Button();
            this.pretty_numbers_checkbox = new System.Windows.Forms.CheckBox();
            this.EventTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // words_written_counter
            // 
            this.words_written_counter.AutoSize = true;
            this.words_written_counter.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.words_written_counter.Location = new System.Drawing.Point(578, 344);
            this.words_written_counter.Name = "words_written_counter";
            this.words_written_counter.Size = new System.Drawing.Size(149, 21);
            this.words_written_counter.TabIndex = 1;
            this.words_written_counter.Text = "Words written: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // anton_count
            // 
            this.anton_count.AutoSize = true;
            this.anton_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anton_count.Location = new System.Drawing.Point(42, 257);
            this.anton_count.Name = "anton_count";
            this.anton_count.Size = new System.Drawing.Size(61, 15);
            this.anton_count.TabIndex = 3;
            this.anton_count.Text = "Antons: 0";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 453);
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
            this.anton_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anton_price.Location = new System.Drawing.Point(42, 244);
            this.anton_price.Name = "anton_price";
            this.anton_price.Size = new System.Drawing.Size(53, 15);
            this.anton_price.TabIndex = 5;
            this.anton_price.Text = "Price: 2";
            // 
            // upgrade_panel
            // 
            this.upgrade_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upgrade_panel.Location = new System.Drawing.Point(12, 277);
            this.upgrade_panel.Name = "upgrade_panel";
            this.upgrade_panel.Size = new System.Drawing.Size(560, 170);
            this.upgrade_panel.TabIndex = 6;
            // 
            // lasse_price
            // 
            this.lasse_price.AutoSize = true;
            this.lasse_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasse_price.Location = new System.Drawing.Point(265, 244);
            this.lasse_price.Name = "lasse_price";
            this.lasse_price.Size = new System.Drawing.Size(77, 15);
            this.lasse_price.TabIndex = 8;
            this.lasse_price.Text = "Price: 1000";
            // 
            // casper_price
            // 
            this.casper_price.AutoSize = true;
            this.casper_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casper_price.Location = new System.Drawing.Point(488, 244);
            this.casper_price.Name = "casper_price";
            this.casper_price.Size = new System.Drawing.Size(93, 15);
            this.casper_price.TabIndex = 14;
            this.casper_price.Text = "Price: 500000";
            // 
            // lasse_count
            // 
            this.lasse_count.AutoSize = true;
            this.lasse_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasse_count.Location = new System.Drawing.Point(265, 257);
            this.lasse_count.Name = "lasse_count";
            this.lasse_count.Size = new System.Drawing.Size(61, 15);
            this.lasse_count.TabIndex = 9;
            this.lasse_count.Text = "Lasses: 0";
            // 
            // casper_count
            // 
            this.casper_count.AutoSize = true;
            this.casper_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casper_count.Location = new System.Drawing.Point(488, 257);
            this.casper_count.Name = "casper_count";
            this.casper_count.Size = new System.Drawing.Size(69, 15);
            this.casper_count.TabIndex = 15;
            this.casper_count.Text = "Caspers: 0";
            // 
            // mads_price
            // 
            this.mads_price.AutoSize = true;
            this.mads_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mads_price.Location = new System.Drawing.Point(711, 244);
            this.mads_price.Name = "mads_price";
            this.mads_price.Size = new System.Drawing.Size(125, 15);
            this.mads_price.TabIndex = 16;
            this.mads_price.Text = "Price: 10.00 Million";
            // 
            // mads_count
            // 
            this.mads_count.AutoSize = true;
            this.mads_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mads_count.Location = new System.Drawing.Point(711, 257);
            this.mads_count.Name = "mads_count";
            this.mads_count.Size = new System.Drawing.Size(59, 15);
            this.mads_count.TabIndex = 17;
            this.mads_count.Text = "Madss: 0";
            // 
            // ezzi_price
            // 
            this.ezzi_price.AutoSize = true;
            this.ezzi_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezzi_price.Location = new System.Drawing.Point(934, 244);
            this.ezzi_price.Name = "ezzi_price";
            this.ezzi_price.Size = new System.Drawing.Size(115, 15);
            this.ezzi_price.TabIndex = 18;
            this.ezzi_price.Text = "Price: 5.00 Billion";
            // 
            // ezzi_count
            // 
            this.ezzi_count.AutoSize = true;
            this.ezzi_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezzi_count.Location = new System.Drawing.Point(934, 257);
            this.ezzi_count.Name = "ezzi_count";
            this.ezzi_count.Size = new System.Drawing.Size(52, 15);
            this.ezzi_count.TabIndex = 19;
            this.ezzi_count.Text = "Ezzis: 0";
            // 
            // thue_price
            // 
            this.thue_price.AutoSize = true;
            this.thue_price.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thue_price.Location = new System.Drawing.Point(1157, 244);
            this.thue_price.Name = "thue_price";
            this.thue_price.Size = new System.Drawing.Size(120, 15);
            this.thue_price.TabIndex = 20;
            this.thue_price.Text = "Price: 1.00 Trillion";
            // 
            // thue_count
            // 
            this.thue_count.AutoSize = true;
            this.thue_count.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thue_count.Location = new System.Drawing.Point(1157, 257);
            this.thue_count.Name = "thue_count";
            this.thue_count.Size = new System.Drawing.Size(56, 15);
            this.thue_count.TabIndex = 21;
            this.thue_count.Text = "Thues: 0";
            // 
            // cheat_button
            // 
            this.cheat_button.Location = new System.Drawing.Point(174, 453);
            this.cheat_button.Name = "cheat_button";
            this.cheat_button.Size = new System.Drawing.Size(152, 23);
            this.cheat_button.TabIndex = 22;
            this.cheat_button.Text = "Give 100 quadrillion words";
            this.cheat_button.UseVisualStyleBackColor = true;
            this.cheat_button.Click += new System.EventHandler(this.cheat_button_Click);
            // 
            // button_thue
            // 
            this.button_thue.CausesValidation = false;
            this.button_thue.Image = global::A312a_clicker.Properties.Resources.thue;
            this.button_thue.Location = new System.Drawing.Point(1160, 12);
            this.button_thue.Name = "button_thue";
            this.button_thue.Size = new System.Drawing.Size(178, 229);
            this.button_thue.TabIndex = 13;
            this.button_thue.UseVisualStyleBackColor = true;
            this.button_thue.Click += new System.EventHandler(this.button_thue_Click);
            // 
            // button_ezzi
            // 
            this.button_ezzi.CausesValidation = false;
            this.button_ezzi.Image = global::A312a_clicker.Properties.Resources.Udklip;
            this.button_ezzi.Location = new System.Drawing.Point(937, 12);
            this.button_ezzi.Name = "button_ezzi";
            this.button_ezzi.Size = new System.Drawing.Size(178, 229);
            this.button_ezzi.TabIndex = 12;
            this.button_ezzi.UseVisualStyleBackColor = true;
            this.button_ezzi.Click += new System.EventHandler(this.button_ezzi_Click);
            // 
            // button_mads
            // 
            this.button_mads.CausesValidation = false;
            this.button_mads.Image = global::A312a_clicker.Properties.Resources.mads;
            this.button_mads.Location = new System.Drawing.Point(714, 12);
            this.button_mads.Name = "button_mads";
            this.button_mads.Size = new System.Drawing.Size(178, 229);
            this.button_mads.TabIndex = 11;
            this.button_mads.UseVisualStyleBackColor = true;
            this.button_mads.Click += new System.EventHandler(this.button_mads_Click);
            // 
            // button_casper
            // 
            this.button_casper.CausesValidation = false;
            this.button_casper.Image = global::A312a_clicker.Properties.Resources.casper1;
            this.button_casper.Location = new System.Drawing.Point(491, 12);
            this.button_casper.Name = "button_casper";
            this.button_casper.Size = new System.Drawing.Size(178, 229);
            this.button_casper.TabIndex = 10;
            this.button_casper.UseVisualStyleBackColor = true;
            this.button_casper.Click += new System.EventHandler(this.button_casper_Click);
            // 
            // button_lasse
            // 
            this.button_lasse.CausesValidation = false;
            this.button_lasse.Image = global::A312a_clicker.Properties.Resources.Lasse1;
            this.button_lasse.Location = new System.Drawing.Point(268, 12);
            this.button_lasse.Name = "button_lasse";
            this.button_lasse.Size = new System.Drawing.Size(178, 229);
            this.button_lasse.TabIndex = 7;
            this.button_lasse.UseVisualStyleBackColor = true;
            this.button_lasse.Click += new System.EventHandler(this.Lasse_Click);
            // 
            // button_anton
            // 
            this.button_anton.Image = global::A312a_clicker.Properties.Resources.Anton1;
            this.button_anton.Location = new System.Drawing.Point(45, 12);
            this.button_anton.Name = "button_anton";
            this.button_anton.Size = new System.Drawing.Size(178, 229);
            this.button_anton.TabIndex = 2;
            this.button_anton.UseVisualStyleBackColor = true;
            this.button_anton.Click += new System.EventHandler(this.Anton_Click);
            // 
            // anton__words_s
            // 
            this.anton__words_s.AutoSize = true;
            this.anton__words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anton__words_s.Location = new System.Drawing.Point(109, 257);
            this.anton__words_s.Name = "anton__words_s";
            this.anton__words_s.Size = new System.Drawing.Size(71, 15);
            this.anton__words_s.TabIndex = 23;
            this.anton__words_s.Text = "Words/s: 0";
            // 
            // lasse_words_s
            // 
            this.lasse_words_s.AutoSize = true;
            this.lasse_words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasse_words_s.Location = new System.Drawing.Point(332, 257);
            this.lasse_words_s.Name = "lasse_words_s";
            this.lasse_words_s.Size = new System.Drawing.Size(71, 15);
            this.lasse_words_s.TabIndex = 24;
            this.lasse_words_s.Text = "Words/s: 0";
            // 
            // casper_words_s
            // 
            this.casper_words_s.AutoSize = true;
            this.casper_words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casper_words_s.Location = new System.Drawing.Point(563, 257);
            this.casper_words_s.Name = "casper_words_s";
            this.casper_words_s.Size = new System.Drawing.Size(71, 15);
            this.casper_words_s.TabIndex = 25;
            this.casper_words_s.Text = "Words/s: 0";
            // 
            // mads_words_s
            // 
            this.mads_words_s.AutoSize = true;
            this.mads_words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mads_words_s.Location = new System.Drawing.Point(776, 257);
            this.mads_words_s.Name = "mads_words_s";
            this.mads_words_s.Size = new System.Drawing.Size(71, 15);
            this.mads_words_s.TabIndex = 26;
            this.mads_words_s.Text = "Words/s: 0";
            // 
            // ezzi_words_s
            // 
            this.ezzi_words_s.AutoSize = true;
            this.ezzi_words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezzi_words_s.Location = new System.Drawing.Point(992, 257);
            this.ezzi_words_s.Name = "ezzi_words_s";
            this.ezzi_words_s.Size = new System.Drawing.Size(71, 15);
            this.ezzi_words_s.TabIndex = 27;
            this.ezzi_words_s.Text = "Words/s: 0";
            // 
            // thue_words_s
            // 
            this.thue_words_s.AutoSize = true;
            this.thue_words_s.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thue_words_s.Location = new System.Drawing.Point(1219, 257);
            this.thue_words_s.Name = "thue_words_s";
            this.thue_words_s.Size = new System.Drawing.Size(71, 15);
            this.thue_words_s.TabIndex = 28;
            this.thue_words_s.Text = "Words/s: 0";
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(93, 453);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 29;
            this.load_button.Text = "Load game";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // pretty_numbers_checkbox
            // 
            this.pretty_numbers_checkbox.AutoSize = true;
            this.pretty_numbers_checkbox.Checked = true;
            this.pretty_numbers_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pretty_numbers_checkbox.Location = new System.Drawing.Point(333, 458);
            this.pretty_numbers_checkbox.Name = "pretty_numbers_checkbox";
            this.pretty_numbers_checkbox.Size = new System.Drawing.Size(98, 17);
            this.pretty_numbers_checkbox.TabIndex = 30;
            this.pretty_numbers_checkbox.Text = "Pretty Numbers";
            this.pretty_numbers_checkbox.UseVisualStyleBackColor = true;
            this.pretty_numbers_checkbox.CheckedChanged += new System.EventHandler(this.pretty_numbers_checkbox_CheckedChanged);
            // 
            // EventTimer
            // 
            this.EventTimer.Interval = 300000;
            this.EventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A312a_clicker.Properties.Resources.sharelatex_transparent_4;
            this.ClientSize = new System.Drawing.Size(1383, 482);
            this.Controls.Add(this.pretty_numbers_checkbox);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.thue_words_s);
            this.Controls.Add(this.ezzi_words_s);
            this.Controls.Add(this.mads_words_s);
            this.Controls.Add(this.casper_words_s);
            this.Controls.Add(this.lasse_words_s);
            this.Controls.Add(this.anton__words_s);
            this.Controls.Add(this.cheat_button);
            this.Controls.Add(this.thue_count);
            this.Controls.Add(this.thue_price);
            this.Controls.Add(this.ezzi_count);
            this.Controls.Add(this.ezzi_price);
            this.Controls.Add(this.mads_count);
            this.Controls.Add(this.mads_price);
            this.Controls.Add(this.casper_count);
            this.Controls.Add(this.casper_price);
            this.Controls.Add(this.button_thue);
            this.Controls.Add(this.button_ezzi);
            this.Controls.Add(this.button_mads);
            this.Controls.Add(this.button_casper);
            this.Controls.Add(this.lasse_count);
            this.Controls.Add(this.lasse_price);
            this.Controls.Add(this.button_lasse);
            this.Controls.Add(this.upgrade_panel);
            this.Controls.Add(this.anton_price);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.anton_count);
            this.Controls.Add(this.button_anton);
            this.Controls.Add(this.words_written_counter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "A312a Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label words_written_counter;
        private System.Windows.Forms.Button button_anton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label anton_count;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label anton_price;
        private System.Windows.Forms.Panel upgrade_panel;
        private System.Windows.Forms.Button button_lasse;
        private System.Windows.Forms.Label lasse_price;
        private System.Windows.Forms.Button button_casper;
        private System.Windows.Forms.Button button_mads;
        private System.Windows.Forms.Button button_ezzi;
        private System.Windows.Forms.Button button_thue;
        private System.Windows.Forms.Label casper_price;
        private System.Windows.Forms.Label lasse_count;
        private System.Windows.Forms.Label casper_count;
        private System.Windows.Forms.Label mads_price;
        private System.Windows.Forms.Label mads_count;
        private System.Windows.Forms.Label ezzi_price;
        private System.Windows.Forms.Label ezzi_count;
        private System.Windows.Forms.Label thue_price;
        private System.Windows.Forms.Label thue_count;
        private System.Windows.Forms.Button cheat_button;
        private System.Windows.Forms.Label anton__words_s;
        private System.Windows.Forms.Label lasse_words_s;
        private System.Windows.Forms.Label casper_words_s;
        private System.Windows.Forms.Label mads_words_s;
        private System.Windows.Forms.Label ezzi_words_s;
        private System.Windows.Forms.Label thue_words_s;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.CheckBox pretty_numbers_checkbox;
        private System.Windows.Forms.Timer EventTimer;
    }
}

