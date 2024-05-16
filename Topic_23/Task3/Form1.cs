using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "�������";
            this.Size = new Size(200, 400);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // ������ ������ ��������
            g.DrawRectangle(Pens.Black, 50, 50, 100, 250);

            // ������ ����� ��������
            g.FillRectangle(Brushes.LightBlue, 60, 60, 80, 120);

            // ������ ������ ��������
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    g.FillEllipse(Brushes.Gray, 60 + j * 30, 200 + i * 30, 20, 20);
                }
            }
        }
    }
}

