using System;
using System.Linq;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private Button maxButton;
        private Button sumButton;
        private Button fillButton;
        private TextBox resultTextBox;
        private int[,] X = new int[15, 15];

        public Form1()
        {
            maxButton = new Button();
            maxButton.Text = "Максимальный элемент";
            maxButton.Width = 250;
            maxButton.Height = 150;
            maxButton.Click += new EventHandler(MaxButton_Click);

            fillButton = new Button();
            fillButton.Text = "Заполнить матрицу";
            fillButton.Width = 200;
            fillButton.Height = 200;
            fillButton.Location = new System.Drawing.Point(0, maxButton.Height + 300);

            fillButton.Click += new EventHandler(FillButton_Click);

            sumButton = new Button();
            sumButton.Text = "Сумма элементов";
            sumButton.Width = 200;
            sumButton.Height = 200;
            sumButton.Location = new System.Drawing.Point(0, maxButton.Height + 20);
            sumButton.Click += new EventHandler(SumButton_Click);

            resultTextBox = new TextBox();
            resultTextBox.Width = 1000;
            resultTextBox.Location = new System.Drawing.Point(0, sumButton.Top + sumButton.Height + 20);

            Controls.Add(maxButton);
            Controls.Add(sumButton);
            Controls.Add(fillButton);
            Controls.Add(resultTextBox);


        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                int j = X.GetLength(1) - i - 1;
                if (X[i, j] > max)
                {
                    max = X[i, j];
                }
            }
            resultTextBox.Text = $"Максимальный элемент на дополнительной диагонали матрицы X: {max}";
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            string sums = string.Join(", ", Enumerable.Range(0, X.GetLength(1)).Select(j => Enumerable.Range(0, X.GetLength(0)).Sum(i => X[i, j])));
            resultTextBox.Text = $"Суммы элементов матрицы Y по столбцам: {sums}";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    X[i, j] = rnd.Next(-100, 100);
                }
            }
        }
    }
}
    