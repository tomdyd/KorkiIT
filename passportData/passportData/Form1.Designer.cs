namespace passportData
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
            numberLabel = new Label();
            nameLabel = new Label();
            surnameLabel = new Label();
            NumberTextBox = new TextBox();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            brownEyesBtn = new RadioButton();
            greenEyesBtn = new RadioButton();
            blueEyesBtn = new RadioButton();
            okBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(32, 33);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(66, 25);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "Numer";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(32, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(46, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(32, 119);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(87, 25);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Nazwisko";
            // 
            // NumberTextBox
            // 
            NumberTextBox.BackColor = Color.Azure;
            NumberTextBox.Location = new Point(153, 33);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(383, 31);
            NumberTextBox.TabIndex = 3;
            NumberTextBox.Leave += NumberTextBox_Leave;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.Azure;
            NameTextBox.Location = new Point(153, 76);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(383, 31);
            NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.Azure;
            SurnameTextBox.Location = new Point(153, 119);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(383, 31);
            SurnameTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(brownEyesBtn);
            groupBox1.Controls.Add(greenEyesBtn);
            groupBox1.Controls.Add(blueEyesBtn);
            groupBox1.Location = new Point(32, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 199);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kolor oczu";
            // 
            // brownEyesBtn
            // 
            brownEyesBtn.AutoSize = true;
            brownEyesBtn.Location = new Point(18, 141);
            brownEyesBtn.Name = "brownEyesBtn";
            brownEyesBtn.Size = new Size(83, 29);
            brownEyesBtn.TabIndex = 2;
            brownEyesBtn.Text = "Piwne";
            brownEyesBtn.UseVisualStyleBackColor = true;
            brownEyesBtn.CheckedChanged += EyesColorBtn_CheckedChanged;
            // 
            // greenEyesBtn
            // 
            greenEyesBtn.AutoSize = true;
            greenEyesBtn.Location = new Point(18, 91);
            greenEyesBtn.Name = "greenEyesBtn";
            greenEyesBtn.Size = new Size(94, 29);
            greenEyesBtn.TabIndex = 1;
            greenEyesBtn.Text = "Zielone";
            greenEyesBtn.UseVisualStyleBackColor = true;
            greenEyesBtn.CheckedChanged += EyesColorBtn_CheckedChanged;
            // 
            // blueEyesBtn
            // 
            blueEyesBtn.AutoSize = true;
            blueEyesBtn.Checked = true;
            blueEyesBtn.Location = new Point(18, 42);
            blueEyesBtn.Name = "blueEyesBtn";
            blueEyesBtn.Size = new Size(117, 29);
            blueEyesBtn.TabIndex = 0;
            blueEyesBtn.TabStop = true;
            blueEyesBtn.Text = "Niebieskie";
            blueEyesBtn.UseVisualStyleBackColor = true;
            blueEyesBtn.CheckedChanged += EyesColorBtn_CheckedChanged;
            // 
            // okBtn
            // 
            okBtn.BackColor = Color.Azure;
            okBtn.Location = new Point(628, 330);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(329, 61);
            okBtn.TabIndex = 7;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += okBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(628, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(817, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1032, 439);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(okBtn);
            Controls.Add(groupBox1);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Controls.Add(numberLabel);
            Name = "Form1";
            Text = "Wprowadzanie danych do paszportu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private Label nameLabel;
        private Label surnameLabel;
        private TextBox NumberTextBox;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private GroupBox groupBox1;
        private RadioButton brownEyesBtn;
        private RadioButton greenEyesBtn;
        private RadioButton blueEyesBtn;
        private Button okBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
