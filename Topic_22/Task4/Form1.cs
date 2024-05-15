using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { NameTextBox, SurnameTextBox, MiddleNameTextBox, emailTextBox, phoneBox };
            ComboBox[] comboBoxes = { LocationTextBox, operatorBox };
            RadioButton[] radioButtons = { MaleRadioButton, FemaleRadioButton };
            RadioButton[] workExpRadioButtons = { NoWorkRB, LessThen1RB, From1To5RB, From5To9RB, MoreThen10RB };
            CheckBox[] categoryCheckboxes = { categoryA, categoryB, categoryC, categoryD };
            RadioButton[] workGraphicRadioButtons = { FullTimeRB, PartTimeRB, WorkAtHomeRB, TimeWorkRB };
            NumericUpDown[] numericUpDowns = { FromSalary, ToSalary };

            string GetSelectedRadioButtonText(RadioButton[] radioButtons)
            {
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton.Text;
                    }
                }
                return "";
            }

            string GetSelectedCheckBoxText(CheckBox[] checkBoxes)
            {
                string result = "";
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        result += checkBox.Text;
                    }
                }
                return result;
            }

            string[] textBoxValues = textBoxes.Select(textBox => textBox.Text).ToArray();

            string[] comboBoxValues = comboBoxes.Select(comboBox => comboBox.Text).ToArray();

            string sex = GetSelectedRadioButtonText(radioButtons);
            string dateOfBirth = DateBirtPicker.Text;

            string workExp = GetSelectedRadioButtonText(workExpRadioButtons);
            if (workExp == "")
            {
                MessageBox.Show("�� ������ ���� ������!!");
                return;
            }

            string driveCategory = GetSelectedCheckBoxText(categoryCheckboxes);

            string workGraphic = GetSelectedRadioButtonText(workGraphicRadioButtons);
            if (workGraphic == "")
            {
                MessageBox.Show("�������� ������ ������!!");
                return;
            }

            string salaryFrom = Convert.ToString(FromSalary.Value);
            string salaryTo = Convert.ToString(ToSalary.Value);

            CVtextBox.AppendText($"���: {textBoxValues[0]}\n");
            CVtextBox.AppendText($"�������: {textBoxValues[1]}\n");
            CVtextBox.AppendText($"��������: {textBoxValues[2]}\n");
            CVtextBox.AppendText($"���: {sex}\n");
            CVtextBox.AppendText($"���� ��������: {dateOfBirth}\n");
            CVtextBox.AppendText($"��������������: {comboBoxValues[0]}\n");
            CVtextBox.AppendText($"Email: {textBoxValues[3]}\n");
            CVtextBox.AppendText($"�������: {textBoxValues[4]}\n");
            CVtextBox.AppendText($"���������� ��������: {comboBoxValues[1]}\n");
            CVtextBox.AppendText($"���� ������: {workExp}\n");
            CVtextBox.AppendText($"����������� ����������: {(haveAuto.Checked ? "��" : "���")}\n");
            CVtextBox.AppendText($"������������ �������������: {(driveLicense.Checked ? "��" : "���")}\n");
            CVtextBox.AppendText($"��������� ������������ ����: {driveCategory}\n");
            CVtextBox.AppendText($"�������� ��: {salaryFrom}\n");
            CVtextBox.AppendText($"�������� ��: {salaryTo}\n");
            CVtextBox.AppendText($"������ ������: {workGraphic}\n");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { NameTextBox, SurnameTextBox, MiddleNameTextBox, emailTextBox, phoneBox };
            ComboBox[] comboBoxes = { LocationTextBox, operatorBox };
            RadioButton[] radioButtons = { MaleRadioButton, FemaleRadioButton };
            RadioButton[] workExpRadioButtons = { NoWorkRB, LessThen1RB, From1To5RB, From5To9RB, MoreThen10RB };
            CheckBox[] categoryCheckboxes = { categoryA, categoryB, categoryC, categoryD };
            RadioButton[] workGraphicRadioButtons = { FullTimeRB, PartTimeRB, WorkAtHomeRB, TimeWorkRB };
            NumericUpDown[] numericUpDowns = { FromSalary, ToSalary };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in categoryCheckboxes)
            {
                checkBox.Checked = false;
            }

            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }

            CVtextBox.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
