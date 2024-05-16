using System;
using System.Linq;
using System.Windows.Forms;
namespace Task5
{
    public partial class Form1 : Form
    {
        private Button calculateButton;
        private TextBox resultTextBox;
        private int[] Z = new int[35]; // Замените это на ваш массив

        public Form1()
        {
            calculateButton = new Button();
            calculateButton.Text = "Вычислить";
            calculateButton.Click += new EventHandler(CalculateButton_Click);

            resultTextBox = new TextBox();
            resultTextBox.Location = new System.Drawing.Point(calculateButton.Left, calculateButton.Height + 10);

            Controls.Add(calculateButton);
            Controls.Add(resultTextBox);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // S – сумма четных элементов, меньших 3
            int S = Z.Where(x => x < 3 && x % 2 == 0).Sum();
            // P – произведение нечетных элементов, больших 1
            int P = Z.Where(x => x > 1 && x % 2 != 0).Aggregate(1, (a, b) => a * b);
            // R=S+P
            int R = S + P;
            resultTextBox.Text = $"R = {R}";
        }
    }
}