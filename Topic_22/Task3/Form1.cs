namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double x0 = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double dx = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);


                for (double x = x0; x <= xk; x += dx)
                {
                    double y = b * Math.Log(x);
                    textBox5.Text += $"x={x}; y={y}" + Environment.NewLine;
                }
            }

        }
    }
