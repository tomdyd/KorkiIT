namespace passportData
{
    public partial class Form1 : Form
    {
        string _eyesColor = "";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#5F9EA0");
        }

        private void NumberTextBox_Leave(object sender, EventArgs e)
        {
            string userInput = NumberTextBox.Text;
            try
            {
                pictureBox1.Image = Image.FromFile($"{userInput}-zdjecie.jpg");
                pictureBox2.Image = Image.FromFile($"{userInput}-odcisk.jpg");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie znaleziono pliku");
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(_eyesColor))
            {
                MessageBox.Show("Wprowadü dane");
                return;
            }
            MessageBox.Show($"{name} {surname} kolor oczu: {_eyesColor}");
        }

        private void EyesColorBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                _eyesColor = rb.Text;
            }
        }
    }
}
