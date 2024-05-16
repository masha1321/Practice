namespace Task4
{
    public partial class Form1 : Form
    {
        private TextBox textBoxLetter;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonCreate;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // ������� ���� ����� � ������
            textBoxLetter = new TextBox { Location = new Point(10, 15), Width = 100 };
            textBoxX = new TextBox { Location = new Point(120, 15), Width = 100 };
            textBoxY = new TextBox { Location = new Point(230, 15), Width = 100 };
            buttonCreate = new Button { Text = "�������", Location = new Point(450, 20) };

            // ��������� ���������� ������� �� ������
            buttonCreate.Click += Create_Click;

            // ��������� �������� �� �����
            Controls.Add(textBoxLetter);
            Controls.Add(textBoxX);
            Controls.Add(textBoxY);
            Controls.Add(buttonCreate);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            // �������� ������ �� ����� �����
            string letter = textBoxLetter.Text.ToUpper();
            int.TryParse(textBoxX.Text, out int x);
            int.TryParse(textBoxY.Text, out int y);

            // ������� ������� ���������� � ����������� �� ��������� �����
            Control control = null;
            switch (letter)
            {
                case "�":
                    control = new Button { Text = "������", BackColor = Color.AliceBlue, Size = new Size(100, 50) };
                    break;
                case "�":
                    control = new TextBox { BackColor = Color.LightYellow, Size = new Size(100, 50) };
                    break;
                case "�":
                    control = new Label { Text = "�����", BackColor = Color.LightGreen, Size = new Size(100, 50) };
                    break;
            }

            // ���� ������� ��� ������, ����������� ��� � ��������� �� �����
            if (control != null)
            {
                control.Location = new Point(x, y);
                control.MouseEnter += (s, args) => Controls.Remove(control); // �������� ��� ��������� �������
                Controls.Add(control);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
