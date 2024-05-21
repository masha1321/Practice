using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawRandomShapes()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                graphics.Clear(this.BackColor);

                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    int x = random.Next(0, this.Width);
                    int y = random.Next(0, this.Height);
                    int width = random.Next(10, 100);
                    int height = random.Next(10, 100);
                    Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        graphics.FillEllipse(brush, x, y, width, height);
                    }
                }
            }
        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            DrawRandomShapes();
        }
    }
}
