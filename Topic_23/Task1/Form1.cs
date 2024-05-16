namespace Task1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(textBox1.Text);
            int j = Int32.Parse(textBox4.Text);

            foreach (var item in listBox1.Items)
            {
                string text = item.ToString();

                if (i >= 0 && i < text.Length && j >= 0 && j < text.Length)
                {
                    char[] arr = text.ToCharArray();
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    label1.Text += new string(arr) + "\n";
                }
                else
                {
                    MessageBox.Show("Индексы выходят за пределы диапазона.");
                }
            }
        }
    }
}
