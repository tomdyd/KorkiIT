namespace WinFormsApp4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numer = new TextBox();
            imie = new TextBox();
            nazwisko = new TextBox();
            groupBox1 = new GroupBox();
            piwne = new RadioButton();
            zielone = new RadioButton();
            niebieskie = new RadioButton();
            ok_btn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 76);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "numer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 103);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "imie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 133);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "nazwisko";
            // 
            // numer
            // 
            numer.BackColor = Color.Azure;
            numer.Location = new Point(213, 74);
            numer.Name = "numer";
            numer.Size = new Size(100, 23);
            numer.TabIndex = 3;
            numer.Leave += numer_Leave;
            // 
            // imie
            // 
            imie.BackColor = Color.Azure;
            imie.Location = new Point(213, 100);
            imie.Name = "imie";
            imie.Size = new Size(100, 23);
            imie.TabIndex = 4;
            // 
            // nazwisko
            // 
            nazwisko.BackColor = Color.Azure;
            nazwisko.Location = new Point(213, 130);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(100, 23);
            nazwisko.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(piwne);
            groupBox1.Controls.Add(zielone);
            groupBox1.Controls.Add(niebieskie);
            groupBox1.Location = new Point(115, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 176);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "kolor oczu";
            // 
            // piwne
            // 
            piwne.AutoSize = true;
            piwne.Location = new Point(16, 74);
            piwne.Name = "piwne";
            piwne.Size = new Size(57, 19);
            piwne.TabIndex = 2;
            piwne.TabStop = true;
            piwne.Text = "piwne";
            piwne.UseVisualStyleBackColor = true;
            // 
            // zielone
            // 
            zielone.AutoSize = true;
            zielone.Location = new Point(16, 49);
            zielone.Name = "zielone";
            zielone.Size = new Size(62, 19);
            zielone.TabIndex = 1;
            zielone.TabStop = true;
            zielone.Text = "zielone";
            zielone.UseVisualStyleBackColor = true;
            // 
            // niebieskie
            // 
            niebieskie.AutoSize = true;
            niebieskie.Location = new Point(16, 23);
            niebieskie.Name = "niebieskie";
            niebieskie.Size = new Size(77, 19);
            niebieskie.TabIndex = 0;
            niebieskie.TabStop = true;
            niebieskie.Text = "niebieskie";
            niebieskie.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            ok_btn.BackColor = Color.Azure;
            ok_btn.Location = new Point(779, 479);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(230, 57);
            ok_btn.TabIndex = 7;
            ok_btn.Text = "ok";
            ok_btn.UseVisualStyleBackColor = false;
            ok_btn.Click += ok_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(682, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 180);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(903, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 180);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1204, 640);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ok_btn);
            Controls.Add(groupBox1);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Controls.Add(numer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "egzamin wykonal:0000000000000";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numer;
        private TextBox imie;
        private TextBox nazwisko;
        private GroupBox groupBox1;
        private RadioButton piwne;
        private RadioButton zielone;
        private RadioButton niebieskie;
        private Button ok_btn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
