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
            this.num_HP = new System.Windows.Forms.NumericUpDown();
            this.num_NRG = new System.Windows.Forms.NumericUpDown();
            this.num_tokens = new System.Windows.Forms.NumericUpDown();
            this.label_HP = new System.Windows.Forms.Label();
            this.label_NRG = new System.Windows.Forms.Label();
            this.label_armor = new System.Windows.Forms.Label();
            this.num_armor = new System.Windows.Forms.NumericUpDown();
            this.label_tokens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_nuts)).BeginInit();
            this.panel_weaponspowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_armor)).BeginInit();
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
            this.panel.Size = new System.Drawing.Size(716, 316);
            this.panel.TabIndex = 2;
            this.panel.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(767, 579);
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
            this.listbox.Location = new System.Drawing.Point(767, 283);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(151, 277);
            this.listbox.TabIndex = 4;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // auglistlabel
            // 
            this.auglistlabel.AutoSize = true;
            this.auglistlabel.Enabled = false;
            this.auglistlabel.Location = new System.Drawing.Point(764, 257);
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
            this.combobox_mainweapon.Location = new System.Drawing.Point(14, 20);
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
            this.panel_weaponspowers.Location = new System.Drawing.Point(549, 12);
            this.panel_weaponspowers.Name = "panel_weaponspowers";
            this.panel_weaponspowers.Size = new System.Drawing.Size(369, 239);
            this.panel_weaponspowers.TabIndex = 12;
            // 
            // label_power8
            // 
            this.label_power8.AutoSize = true;
            this.label_power8.Location = new System.Drawing.Point(192, 200);
            this.label_power8.Name = "label_power8";
            this.label_power8.Size = new System.Drawing.Size(46, 13);
            this.label_power8.TabIndex = 28;
            this.label_power8.Text = "Power 8";
            // 
            // label_power7
            // 
            this.label_power7.AutoSize = true;
            this.label_power7.Location = new System.Drawing.Point(192, 151);
            this.label_power7.Name = "label_power7";
            this.label_power7.Size = new System.Drawing.Size(46, 13);
            this.label_power7.TabIndex = 27;
            this.label_power7.Text = "Power 7";
            // 
            // label_power6
            // 
            this.label_power6.AutoSize = true;
            this.label_power6.Location = new System.Drawing.Point(192, 101);
            this.label_power6.Name = "label_power6";
            this.label_power6.Size = new System.Drawing.Size(46, 13);
            this.label_power6.TabIndex = 26;
            this.label_power6.Text = "Power 6";
            // 
            // label_power5
            // 
            this.label_power5.AutoSize = true;
            this.label_power5.Location = new System.Drawing.Point(192, 53);
            this.label_power5.Name = "label_power5";
            this.label_power5.Size = new System.Drawing.Size(46, 13);
            this.label_power5.TabIndex = 25;
            this.label_power5.Text = "Power 5";
            // 
            // label_power4
            // 
            this.label_power4.AutoSize = true;
            this.label_power4.Location = new System.Drawing.Point(11, 200);
            this.label_power4.Name = "label_power4";
            this.label_power4.Size = new System.Drawing.Size(46, 13);
            this.label_power4.TabIndex = 24;
            this.label_power4.Text = "Power 4";
            // 
            // label_power3
            // 
            this.label_power3.AutoSize = true;
            this.label_power3.Location = new System.Drawing.Point(11, 151);
            this.label_power3.Name = "label_power3";
            this.label_power3.Size = new System.Drawing.Size(46, 13);
            this.label_power3.TabIndex = 23;
            this.label_power3.Text = "Power 3";
            // 
            // label_power2
            // 
            this.label_power2.AutoSize = true;
            this.label_power2.Location = new System.Drawing.Point(11, 101);
            this.label_power2.Name = "label_power2";
            this.label_power2.Size = new System.Drawing.Size(46, 13);
            this.label_power2.TabIndex = 22;
            this.label_power2.Text = "Power 2";
            // 
            // label_power1
            // 
            this.label_power1.AutoSize = true;
            this.label_power1.Location = new System.Drawing.Point(11, 53);
            this.label_power1.Name = "label_power1";
            this.label_power1.Size = new System.Drawing.Size(46, 13);
            this.label_power1.TabIndex = 21;
            this.label_power1.Text = "Power 1";
            // 
            // combobox_power8
            // 
            this.combobox_power8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power8.FormattingEnabled = true;
            this.combobox_power8.Location = new System.Drawing.Point(195, 216);
            this.combobox_power8.Name = "combobox_power8";
            this.combobox_power8.Size = new System.Drawing.Size(159, 21);
            this.combobox_power8.TabIndex = 20;
            // 
            // combobox_power7
            // 
            this.combobox_power7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power7.FormattingEnabled = true;
            this.combobox_power7.Location = new System.Drawing.Point(195, 167);
            this.combobox_power7.Name = "combobox_power7";
            this.combobox_power7.Size = new System.Drawing.Size(159, 21);
            this.combobox_power7.TabIndex = 19;
            // 
            // combobox_power6
            // 
            this.combobox_power6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power6.FormattingEnabled = true;
            this.combobox_power6.Location = new System.Drawing.Point(195, 118);
            this.combobox_power6.Name = "combobox_power6";
            this.combobox_power6.Size = new System.Drawing.Size(159, 21);
            this.combobox_power6.TabIndex = 18;
            // 
            // combobox_power5
            // 
            this.combobox_power5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power5.FormattingEnabled = true;
            this.combobox_power5.Location = new System.Drawing.Point(195, 69);
            this.combobox_power5.Name = "combobox_power5";
            this.combobox_power5.Size = new System.Drawing.Size(159, 21);
            this.combobox_power5.TabIndex = 17;
            // 
            // combobox_power4
            // 
            this.combobox_power4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power4.FormattingEnabled = true;
            this.combobox_power4.Location = new System.Drawing.Point(14, 216);
            this.combobox_power4.Name = "combobox_power4";
            this.combobox_power4.Size = new System.Drawing.Size(159, 21);
            this.combobox_power4.TabIndex = 16;
            // 
            // combobox_power3
            // 
            this.combobox_power3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power3.FormattingEnabled = true;
            this.combobox_power3.Location = new System.Drawing.Point(14, 167);
            this.combobox_power3.Name = "combobox_power3";
            this.combobox_power3.Size = new System.Drawing.Size(159, 21);
            this.combobox_power3.TabIndex = 15;
            // 
            // combobox_power2
            // 
            this.combobox_power2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power2.FormattingEnabled = true;
            this.combobox_power2.Location = new System.Drawing.Point(14, 118);
            this.combobox_power2.Name = "combobox_power2";
            this.combobox_power2.Size = new System.Drawing.Size(159, 21);
            this.combobox_power2.TabIndex = 14;
            // 
            // combobox_power1
            // 
            this.combobox_power1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_power1.FormattingEnabled = true;
            this.combobox_power1.Location = new System.Drawing.Point(14, 69);
            this.combobox_power1.Name = "combobox_power1";
            this.combobox_power1.Size = new System.Drawing.Size(159, 21);
            this.combobox_power1.TabIndex = 13;
            // 
            // label_mainweapon
            // 
            this.label_mainweapon.AutoSize = true;
            this.label_mainweapon.Location = new System.Drawing.Point(11, 2);
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
            // num_HP
            // 
            this.num_HP.Enabled = false;
            this.num_HP.Location = new System.Drawing.Point(372, 86);
            this.num_HP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_HP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_HP.Name = "num_HP";
            this.num_HP.Size = new System.Drawing.Size(120, 20);
            this.num_HP.TabIndex = 17;
            this.num_HP.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // num_NRG
            // 
            this.num_NRG.DecimalPlaces = 1;
            this.num_NRG.Enabled = false;
            this.num_NRG.Location = new System.Drawing.Point(372, 129);
            this.num_NRG.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_NRG.Name = "num_NRG";
            this.num_NRG.Size = new System.Drawing.Size(120, 20);
            this.num_NRG.TabIndex = 18;
            this.num_NRG.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // num_tokens
            // 
            this.num_tokens.Enabled = false;
            this.num_tokens.Location = new System.Drawing.Point(209, 85);
            this.num_tokens.Name = "num_tokens";
            this.num_tokens.Size = new System.Drawing.Size(120, 20);
            this.num_tokens.TabIndex = 19;
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.Enabled = false;
            this.label_HP.Location = new System.Drawing.Point(369, 69);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(22, 13);
            this.label_HP.TabIndex = 21;
            this.label_HP.Text = "HP";
            this.label_HP.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_NRG
            // 
            this.label_NRG.AutoSize = true;
            this.label_NRG.Enabled = false;
            this.label_NRG.Location = new System.Drawing.Point(369, 113);
            this.label_NRG.Name = "label_NRG";
            this.label_NRG.Size = new System.Drawing.Size(31, 13);
            this.label_NRG.TabIndex = 22;
            this.label_NRG.Text = "NRG";
            // 
            // label_armor
            // 
            this.label_armor.AutoSize = true;
            this.label_armor.Enabled = false;
            this.label_armor.Location = new System.Drawing.Point(369, 154);
            this.label_armor.Name = "label_armor";
            this.label_armor.Size = new System.Drawing.Size(34, 13);
            this.label_armor.TabIndex = 24;
            this.label_armor.Text = "Armor";
            // 
            // num_armor
            // 
            this.num_armor.Enabled = false;
            this.num_armor.Location = new System.Drawing.Point(372, 171);
            this.num_armor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_armor.Name = "num_armor";
            this.num_armor.Size = new System.Drawing.Size(120, 20);
            this.num_armor.TabIndex = 23;
            // 
            // label_tokens
            // 
            this.label_tokens.AutoSize = true;
            this.label_tokens.Enabled = false;
            this.label_tokens.Location = new System.Drawing.Point(206, 69);
            this.label_tokens.Name = "label_tokens";
            this.label_tokens.Size = new System.Drawing.Size(43, 13);
            this.label_tokens.TabIndex = 25;
            this.label_tokens.Text = "Tokens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 633);
            this.Controls.Add(this.label_tokens);
            this.Controls.Add(this.label_armor);
            this.Controls.Add(this.num_armor);
            this.Controls.Add(this.label_NRG);
            this.Controls.Add(this.label_HP);
            this.Controls.Add(this.num_tokens);
            this.Controls.Add(this.num_NRG);
            this.Controls.Add(this.num_HP);
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
            this.Text = "BetterRuns v0.79";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_nuts)).EndInit();
            this.panel_weaponspowers.ResumeLayout(false);
            this.panel_weaponspowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_armor)).EndInit();
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
        private System.Windows.Forms.NumericUpDown num_HP;
        private System.Windows.Forms.NumericUpDown num_NRG;
        private System.Windows.Forms.NumericUpDown num_tokens;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label_NRG;
        private System.Windows.Forms.Label label_armor;
        private System.Windows.Forms.NumericUpDown num_armor;
        private System.Windows.Forms.Label label_tokens;
    }
}

