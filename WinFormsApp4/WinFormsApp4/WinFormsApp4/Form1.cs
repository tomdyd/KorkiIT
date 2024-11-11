using System.Reflection;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ok_btn_Click(object sender, EventArgs e)
        {

            string imie = this.imie.Text;
            string nazwisko = this.nazwisko.Text;
            string Kolor = " ";

            if (niebieskie.Checked)
            {
                Kolor = niebieskie.Text + "\n";
            }
            else if (zielone.Checked)
            {
                Kolor = zielone.Text + "\n";
            }
            else if (piwne.Checked)
            {
                Kolor = piwne.Text + "\n";
            }


            if (string.IsNullOrWhiteSpace(imie))
            {
                MessageBox.Show("Podaj Imiê");
                return;
            }

            if(string.IsNullOrWhiteSpace(nazwisko))
            {
                MessageBox.Show("Podaj nazwisko");
            }

            MessageBox.Show($"{imie} {nazwisko} Kolor oczu:{Kolor} ");
        }

        private void numer_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(numer.Text);
            if (numer.Text == "111")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\111-zdjecie.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\111-odcisk.jpg");
            }
            else if (numer.Text == "000")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\000-zdjecie.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\000-odcisk.jpg");
            }
            else if (numer.Text == "333")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\333-zdjecie.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Users\\tdyda\\source\\repos\\KorkiIT\\passportData\\passportData\\bin\\Debug\\net8.0-windows\\333-odcisk.jpg");
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }


        }
    }
}
