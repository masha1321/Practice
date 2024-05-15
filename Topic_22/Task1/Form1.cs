using System.Data;
using System.Globalization;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,981*2,71-2";
            textBox2.Text = "-1,625*2,713";
            textBox3.Text = "-0,512";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(new DataTable().Compute(textBox1.Text.Replace(',', '.'), null));

            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            double y = Convert.ToDouble(new DataTable().Compute(textBox2.Text.Replace(',', '.'), null));

            
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = double.Parse(textBox3.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Pow(-2, -x) * Math.Sqrt(x + 4 * Math.Pow(3, 1 / 2)) * Math.Pow(Math.E, x - 1) / Math.Sin(z);
            double b = Math.Pow(y * Math.Abs(x) + Math.Pow(Math.Cos(y), 3), 1 / 3) * Math.Exp(Math.Abs(x - y)) + x / 2;
            textBox4.Text += Environment.NewLine + "Резльтат a = " + a.ToString();
            textBox4.Text += Environment.NewLine + "Результат b = " + b.ToString();
        }
    }
}
