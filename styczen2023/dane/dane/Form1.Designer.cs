namespace dane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label = new Label();
            _nazwisko = new Label();
            nazwisko = new TextBox();
            imie = new TextBox();
            _imie = new Label();
            groupBox2 = new GroupBox();
            ile_znakow = new TextBox();
            label1 = new Label();
            znaki = new CheckBox();
            cyfry = new CheckBox();
            litery = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(_nazwisko);
            groupBox1.Controls.Add(nazwisko);
            groupBox1.Controls.Add(imie);
            groupBox1.Controls.Add(_imie);
            groupBox1.Location = new Point(134, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "dane pracownika";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBox1.Location = new Point(79, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(7, 107);
            label.Name = "label";
            label.Size = new Size(66, 15);
            label.TabIndex = 4;
            label.Text = "stanowisko";
            // 
            // _nazwisko
            // 
            _nazwisko.AutoSize = true;
            _nazwisko.Location = new Point(7, 69);
            _nazwisko.Name = "_nazwisko";
            _nazwisko.Size = new Size(55, 15);
            _nazwisko.TabIndex = 3;
            _nazwisko.Text = "nazwisko";
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(79, 67);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(140, 23);
            nazwisko.TabIndex = 2;
            // 
            // imie
            // 
            imie.Location = new Point(80, 28);
            imie.Name = "imie";
            imie.Size = new Size(139, 23);
            imie.TabIndex = 1;
            // 
            // _imie
            // 
            _imie.AutoSize = true;
            _imie.Location = new Point(7, 31);
            _imie.Name = "_imie";
            _imie.Size = new Size(30, 15);
            _imie.TabIndex = 0;
            _imie.Text = "imie";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ile_znakow);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(znaki);
            groupBox2.Controls.Add(cyfry);
            groupBox2.Controls.Add(litery);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(542, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "generowanie hasła";
            // 
            // ile_znakow
            // 
            ile_znakow.Location = new Point(109, 35);
            ile_znakow.Name = "ile_znakow";
            ile_znakow.Size = new Size(115, 23);
            ile_znakow.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "ile znakow?";
            // 
            // znaki
            // 
            znaki.AutoSize = true;
            znaki.Location = new Point(20, 134);
            znaki.Name = "znaki";
            znaki.Size = new Size(105, 19);
            znaki.TabIndex = 3;
            znaki.Text = "znaki specjalne";
            znaki.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            cyfry.AutoSize = true;
            cyfry.Location = new Point(20, 109);
            cyfry.Name = "cyfry";
            cyfry.Size = new Size(52, 19);
            cyfry.TabIndex = 2;
            cyfry.Text = "cyfry";
            cyfry.UseVisualStyleBackColor = true;
            // 
            // litery
            // 
            litery.AutoSize = true;
            litery.Location = new Point(20, 84);
            litery.Name = "litery";
            litery.Size = new Size(126, 19);
            litery.TabIndex = 1;
            litery.Text = "male i wielkie litery";
            litery.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(79, 170);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 0;
            button1.Text = "generuj haslo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(419, 445);
            button2.Name = "button2";
            button2.Size = new Size(131, 60);
            button2.TabIndex = 2;
            button2.Text = "zatwierdz";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1114, 598);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label;
        private Label _nazwisko;
        private TextBox nazwisko;
        private TextBox imie;
        private Label _imie;
        private GroupBox groupBox2;
        private TextBox ile_znakow;
        private Label label1;
        private CheckBox znaki;
        private CheckBox cyfry;
        private CheckBox litery;
        private Button button1;
        private Button button2;
    }
}
