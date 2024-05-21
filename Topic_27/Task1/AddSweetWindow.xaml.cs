using System.Windows;


namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AddSweetWindow.xaml
    /// </summary>
    public partial class AddSweetWindow : Window
    {
        public string SweetType { get; private set; }
        public double SweetPrice { get; private set; }

        public AddSweetWindow()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            SweetType = textBoxSweetType.Text;
            SweetPrice = double.Parse(textBoxSweetPrice.Text);
            DialogResult = true;
            Close();
        }
    }
}
