namespace ConversorCelsiusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SelectInput.SelectedIndex == 0)
            {
                double grausCelsius = 0;
                double grausFarenheit = 0;
                double.TryParse(InputTop.Text, out grausCelsius);
                grausFarenheit = 1.8 * grausCelsius + 32;
                InputBottom.Text = $"{grausFarenheit}";
            }
            else if (SelectInput.SelectedIndex == 1)
            {
                double grausFarenheit = 0;
                double grausCelsius = 0;
                double.TryParse(InputTop.Text, out grausFarenheit);
                grausCelsius = 0.555 * (grausFarenheit -32);
                InputBottom.Text = $"{grausCelsius}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(SelectInput.SelectedIndex == 0)
            {
                LblTop.Text = "Celsius";
                LblBottom.Text = "Fahrenheit";
                InputBottom.Text = "";
                InputTop.Text = "";
            } else if(SelectInput.SelectedIndex == 1)
            {
                LblTop.Text = "Fahrenheit";
                LblBottom.Text = "Celsius";
                InputBottom.Text = "";
                InputTop.Text = "";
            }
           else
            {
                return;
                InputBottom.Text = "";
                InputTop.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}