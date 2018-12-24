namespace BetterRuns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_openfile = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.auglistlabel = new System.Windows.Forms.Label();
            this.buttonlistlabel = new System.Windows.Forms.Label();
            this.combobox_contractors = new System.Windows.Forms.ComboBox();
            this.num_nuts = new System.Windows.Forms.NumericUpDown();
            this.label_character = new System.Windows.Forms.Label();
            this.label_nuts = new System.Windows.Forms.Label();
            this.combobox_mainweapon = new System.Windows.Forms.ComboBox();
            this.panel_weaponspowers = new System.Windows.Forms.Panel();
            this.label_power8 = new System.Windows.Forms.Label();
            this.label_power7 = new System.Windows.Forms.Label();
            this.label_power6 = new System.Windows.Forms.Label();
            this.label_power5 = new System.Windows.Forms.Label();
            this.label_power4 = new System.Windows.Forms.Label();
            this.label_power3 = new System.Windows.Forms.Label();
            this.label_power2 = new System.Windows.Forms.Label();
            this.label_power1 = new System.Windows.Forms.Label();
            this.combobox_power8 = new System.Windows.Forms.ComboBox();
            this.combobox_power7 = new System.Windows.Forms.ComboBox();
            this.combobox_power6 = new System.Windows.Forms.ComboBox();
            this.combobox_power5 = new System.Windows.Forms.ComboBox();
            this.combobox_power4 = new System.Windows.Forms.ComboBox();
            this.combobox_power3 = new System.Windows.Forms.ComboBox();
            this.combobox_power2 = new System.Windows.Forms.ComboBox();
            this.combobox_power1 = new System.Windows.Forms.ComboBox();
            this.label_mainweapon = new System.Windows.Forms.Label();
            this.combobox_mode = new System.Windows.Forms.ComboBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_lives = new System.Windows.Forms.Label();
            this.num_lives = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_nuts)).BeginInit();
            this.panel_weaponspowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lives)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(34, 30);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(217, 23);
            this.btn_openfile.TabIndex = 1;
            this.btn_openfile.Text = "Open 20xx.run file";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(34, 283);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.panel.Size = new System.Drawing.Size(566, 316);
            this.panel.TabIndex = 2;
            this.panel.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(620, 579);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(151, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // listbox
            // 
            this.listbox.Enabled = false;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(620, 283);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(151, 277);
            this.listbox.TabIndex = 4;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // auglistlabel
            // 
            this.auglistlabel.AutoSize = true;
            this.auglistlabel.Enabled = false;
            this.auglistlabel.Location = new System.Drawing.Point(617, 257);
            this.auglistlabel.Name = "auglistlabel";
            this.auglistlabel.Size = new System.Drawing.Size(135, 13);
            this.auglistlabel.TabIndex = 5;
            this.auglistlabel.Text = "Augs – double-click to add:";
            // 
            // buttonlistlabel
            // 
            this.buttonlistlabel.AutoSize = true;
            this.buttonlistlabel.Enabled = false;
            this.buttonlistlabel.Location = new System.Drawing.Point(31, 257);
            this.buttonlistlabel.Name = "buttonlistlabel";
            this.buttonlistlabel.Size = new System.Drawing.Size(117, 13);
            this.buttonlistlabel.TabIndex = 6;
            this.buttonlistlabel.Text = "Augs – click to remove:";
            this.buttonlistlabel.Click += new System.EventHandler(this.buttonlistlabel_Click);
            // 
            // combobox_contractors
            // 
            this.combobox_contractors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_contractors.Enabled = false;
            this.combobox_contractors.FormattingEnabled = true;
            this.combobox_contractors.Location = new System.Drawing.Point(34, 85);
            this.combobox_contractors.Name = "combobox_contractors";
            this.combobox_contractors.Size = new System.Drawing.Size(121, 21);
            this.combobox_contractors.TabIndex = 7;
            this.combobox_contractors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // num_nuts
            // 
            this.num_nuts.Enabled = false;
            this.num_nuts.Location = new System.Drawing.Point(34, 127);
            this.num_nuts.Maximum = new decimal(new int[] {
            1879048191,
            0,
            0,
            0});
            this.num_nuts.Name = "num_nuts";
            this.num_nuts.Size = new System.Drawing.Size(120, 20);
            this.num_nuts.TabIndex = 8;
            this.num_nuts.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_character
            // 
            this.label_character.AutoSize = true;
            this.label_character.Enabled = false;
            this.label_character.Location = new System.Drawing.Point(31, 69);
            this.label_character.Name = "label_character";
            this.label_character.Size = new System.Drawing.Size(53, 13);
            this.label_character.TabIndex = 9;
            this.label_character.Text = "Character";
            // 
            // label_nuts
            // 
            this.label_nuts.AutoSize = true;
            this.label_nuts.Enabled = false;
            this.label_nuts.Location = new System.Drawing.Point(31, 111);
            this.label_nuts.Name = "label_nuts";
            this.label_nuts.Size = new System.Drawing.Size(29, 13);
            this.label_nuts.TabIndex = 10;
            this.label_nuts.Text = "Nuts";
            // 
            // combobox_mainweapon
            // 
            this.combobox_mainweapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_mainweapon.FormattingEnabled = true;
            this.combobox_mainweapon.Location = new System.Drawing.Point(14, 18);
            this.combobox_mainweapon.Name = "combobox_mainweapon";
            this.combobox_mainweapon.Size = new System.Drawing.Size(159, 21);
            this.combobox_mainweapon.TabIndex = 11;
            this.combobox_mainweapon.SelectedIndexChanged += new System.EventHandler(this.combobox_mainweapon_SelectedIndexChanged);
            // 
            // panel_weaponspowers
            // 
            this.panel_weaponspowers.Controls.Add(this.label_power8);
            this.panel_weaponspowers.Controls.Add(this.label_power7);
            this.panel_weaponspowers.Controls.Add(this.label_power6);
            this.panel_weaponspowers.Controls.Add(this.label_power5);
            this.panel_weaponspowers.Controls.Add(this.label_power4);
            this.panel_weaponspowers.Controls.Add(this.label_power3);
            this.panel_weaponspowers.Controls.Add(this.label_power2);
            this.panel_weaponspowers.Controls.Add(this.label_power1);
            this.panel_weaponspowers.Controls.Add(this.combobox_power8);
            this.panel_weaponspowers.Controls.Add(this.combobox_power7);
            this.panel_weaponspowers.Controls.Add(this.combobox_power6);
            this.panel_weaponspowers.Controls.Add(this.combobox_power5);
            this.panel_weaponspowers.Controls.Add(this.combobox_power4);
            this.panel_weaponspowers.Controls.Add(this.combobox_power3);
            this.panel_weaponspowers.Controls.Add(this.combobox_power2);
            this.panel_weaponspowers.Controls.Add(this.combobox_power1);
            this.panel_weaponspowers.Controls.Add(this.label_mainweapon);
            this.panel_weaponspowers.Controls.Add(this.combobox_mainweapon);
            this.panel_weaponspowers.Enabled = false;
            this.panel_weaponspowers.Location = new System.Drawing.Point(315, 12);
            this.panel_weaponspowers.Name = "panel_weaponspowers";
            this.panel_weaponspowers.Size = new System.Drawing.Size(456, 239);
            this.panel_weaponspowers.TabIndex = 12;
            // 
            // label_power8
            // 
            this.label_power8.AutoSize = true;
            this.label_power8.Location = new System.Drawing.Point(242, 198);
            this.label_power8.Name = "label_power8";
            this.label_power8.Size = new System.Drawing.Size(46, 13);
            this.label_power8.TabIndex = 28;
            this.label_power8.Text = "Power 8";
            // 
            // label_power7
            // 
            this.label_power7.AutoSize = true;
            this.label_power7.Location = new System.Drawing.Point(242, 149);
            this.label_power7.Name = "label_power7";
            this.label_power7.Size = new System.Drawing.Size(46, 13);
            this.label_power7.TabIndex = 27;
            this.label_power7.Text = "Power 7";
            // 
            // label_power6
            // 
            this.label_power6.AutoSize = true;
            this.label_power6.Location = new System.Drawing.Point(242, 99);
            this.label_power6.Name = "label_power6";
            this.label_power6.Size = new System.Drawing.Size(46, 13);
            this.label_power6.TabIndex = 26;
            this.label_power6.Text = "Power 6";
            // 
            // label_power5
            // 
            this.label_power5.AutoSize = true;
            this.label_power5.Location = new System.Drawing.Point(242, 51);
            this.label_power5.Name = "label_power5";
            this.label_power5.Size = new System.Drawing.Size(46, 13);
            this.label_power5.TabIndex = 25;
            this.label_power5.Text = "Power 5";
            // 
            // label_power4
            // 
            this.label_power4.AutoSize = true;
            this.label_power4.Location = new System.Drawing.Point(11, 198);
            this.label_power4.Name = "label_power4";
            this.label_power4.Size = new System.Drawing.Size(46, 13);
            this.label_power4.TabIndex = 24;
            this.label_power4.Text = "Power 4";
            // 
            // label_power3
            // 
            this.label_power3.AutoSize = true;
            this.label_power3.Location = new System.Drawing.Point(11, 149);
            this.label_power3.Name = "label_power3";
            this.label_power3.Size = new System.Drawing.Size(46, 13);
            this.label_power3.TabIndex = 23;
            this.label_power3.Text = "Power 3";
            // 
            // label_power2
            // 
            this.label_power2.AutoSize = true;
            this.label_power2.Location = new System.Drawing.Point(11, 99);
            this.label_power2.Name = "label_power2";
            this.label_power2.Size = new System.Drawing.Size(46, 13);
            this.label_power2.TabIndex = 22;
            this.label_power2.Text = "Power 2";
            // 
            // label_power1
            // 
            this.label_power1.AutoSize = true;
            this.label_power1.Location = new System.Drawing.Point(11, 51);
            this.label_power1.Name = "label_power1";
            this.label_power1.Size = new System.Drawing.Size(46, 13);
            this.label_power1.TabIndex = 21;
            this.label_power1.Text = "Power 1";
            // 
            // combobox_power8
            // 
            this.combobox_power8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power8.FormattingEnabled = true;
            this.combobox_power8.Location = new System.Drawing.Point(245, 214);
            this.combobox_power8.Name = "combobox_power8";
            this.combobox_power8.Size = new System.Drawing.Size(159, 21);
            this.combobox_power8.TabIndex = 20;
            // 
            // combobox_power7
            // 
            this.combobox_power7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power7.FormattingEnabled = true;
            this.combobox_power7.Location = new System.Drawing.Point(245, 165);
            this.combobox_power7.Name = "combobox_power7";
            this.combobox_power7.Size = new System.Drawing.Size(159, 21);
            this.combobox_power7.TabIndex = 19;
            // 
            // combobox_power6
            // 
            this.combobox_power6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power6.FormattingEnabled = true;
            this.combobox_power6.Location = new System.Drawing.Point(245, 116);
            this.combobox_power6.Name = "combobox_power6";
            this.combobox_power6.Size = new System.Drawing.Size(159, 21);
            this.combobox_power6.TabIndex = 18;
            // 
            // combobox_power5
            // 
            this.combobox_power5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power5.FormattingEnabled = true;
            this.combobox_power5.Location = new System.Drawing.Point(245, 67);
            this.combobox_power5.Name = "combobox_power5";
            this.combobox_power5.Size = new System.Drawing.Size(159, 21);
            this.combobox_power5.TabIndex = 17;
            // 
            // combobox_power4
            // 
            this.combobox_power4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power4.FormattingEnabled = true;
            this.combobox_power4.Location = new System.Drawing.Point(14, 214);
            this.combobox_power4.Name = "combobox_power4";
            this.combobox_power4.Size = new System.Drawing.Size(159, 21);
            this.combobox_power4.TabIndex = 16;
            // 
            // combobox_power3
            // 
            this.combobox_power3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power3.FormattingEnabled = true;
            this.combobox_power3.Location = new System.Drawing.Point(14, 165);
            this.combobox_power3.Name = "combobox_power3";
            this.combobox_power3.Size = new System.Drawing.Size(159, 21);
            this.combobox_power3.TabIndex = 15;
            // 
            // combobox_power2
            // 
            this.combobox_power2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power2.FormattingEnabled = true;
            this.combobox_power2.Location = new System.Drawing.Point(14, 116);
            this.combobox_power2.Name = "combobox_power2";
            this.combobox_power2.Size = new System.Drawing.Size(159, 21);
            this.combobox_power2.TabIndex = 14;
            // 
            // combobox_power1
            // 
            this.combobox_power1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power1.FormattingEnabled = true;
            this.combobox_power1.Location = new System.Drawing.Point(14, 67);
            this.combobox_power1.Name = "combobox_power1";
            this.combobox_power1.Size = new System.Drawing.Size(159, 21);
            this.combobox_power1.TabIndex = 13;
            // 
            // label_mainweapon
            // 
            this.label_mainweapon.AutoSize = true;
            this.label_mainweapon.Location = new System.Drawing.Point(11, 0);
            this.label_mainweapon.Name = "label_mainweapon";
            this.label_mainweapon.Size = new System.Drawing.Size(74, 13);
            this.label_mainweapon.TabIndex = 12;
            this.label_mainweapon.Text = "Main Weapon";
            this.label_mainweapon.Click += new System.EventHandler(this.label1_Click);
            // 
            // combobox_mode
            // 
            this.combobox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_mode.Enabled = false;
            this.combobox_mode.FormattingEnabled = true;
            this.combobox_mode.Location = new System.Drawing.Point(34, 170);
            this.combobox_mode.Name = "combobox_mode";
            this.combobox_mode.Size = new System.Drawing.Size(160, 21);
            this.combobox_mode.TabIndex = 13;
            this.combobox_mode.SelectedIndexChanged += new System.EventHandler(this.combobox_mode_SelectedIndexChanged);
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Enabled = false;
            this.label_mode.Location = new System.Drawing.Point(31, 154);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(65, 13);
            this.label_mode.TabIndex = 14;
            this.label_mode.Text = "Game Mode";
            // 
            // label_lives
            // 
            this.label_lives.AutoSize = true;
            this.label_lives.Enabled = false;
            this.label_lives.Location = new System.Drawing.Point(34, 198);
            this.label_lives.Name = "label_lives";
            this.label_lives.Size = new System.Drawing.Size(115, 13);
            this.label_lives.TabIndex = 15;
            this.label_lives.Text = "Lives (Reverent Mode)";
            // 
            // num_lives
            // 
            this.num_lives.Enabled = false;
            this.num_lives.Location = new System.Drawing.Point(34, 215);
            this.num_lives.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_lives.Name = "num_lives";
            this.num_lives.Size = new System.Drawing.Size(120, 20);
            this.num_lives.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 633);
            this.Controls.Add(this.num_lives);
            this.Controls.Add(this.label_lives);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.combobox_mode);
            this.Controls.Add(this.panel_weaponspowers);
            this.Controls.Add(this.label_nuts);
            this.Controls.Add(this.label_character);
            this.Controls.Add(this.num_nuts);
            this.Controls.Add(this.combobox_contractors);
            this.Controls.Add(this.buttonlistlabel);
            this.Controls.Add(this.auglistlabel);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_openfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BetterRuns v0.69";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_nuts)).EndInit();
            this.panel_weaponspowers.ResumeLayout(false);
            this.panel_weaponspowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label auglistlabel;
        private System.Windows.Forms.Label buttonlistlabel;
        private System.Windows.Forms.ComboBox combobox_contractors;
        private System.Windows.Forms.NumericUpDown num_nuts;
        private System.Windows.Forms.Label label_character;
        private System.Windows.Forms.Label label_nuts;
        private System.Windows.Forms.ComboBox combobox_mainweapon;
        private System.Windows.Forms.Panel panel_weaponspowers;
        private System.Windows.Forms.Label label_mainweapon;
        private System.Windows.Forms.ComboBox combobox_power8;
        private System.Windows.Forms.ComboBox combobox_power7;
        private System.Windows.Forms.ComboBox combobox_power6;
        private System.Windows.Forms.ComboBox combobox_power5;
        private System.Windows.Forms.ComboBox combobox_power4;
        private System.Windows.Forms.ComboBox combobox_power3;
        private System.Windows.Forms.ComboBox combobox_power2;
        private System.Windows.Forms.ComboBox combobox_power1;
        private System.Windows.Forms.Label label_power8;
        private System.Windows.Forms.Label label_power7;
        private System.Windows.Forms.Label label_power6;
        private System.Windows.Forms.Label label_power5;
        private System.Windows.Forms.Label label_power4;
        private System.Windows.Forms.Label label_power3;
        private System.Windows.Forms.Label label_power2;
        private System.Windows.Forms.Label label_power1;
        private System.Windows.Forms.ComboBox combobox_mode;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Label label_lives;
        private System.Windows.Forms.NumericUpDown num_lives;
    }
}

