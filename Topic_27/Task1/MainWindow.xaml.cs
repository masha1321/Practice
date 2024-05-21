using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Task1.Interfaces;
using Task1.Models;
using Task1.Share;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;

        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information)).CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void ButtonFindSweetType_Click(object sender, RoutedEventArgs e)
        {
            if (IsFileOpened)
            {
                if (!string.IsNullOrEmpty(textBoxSweetType.Text) || !string.IsNullOrWhiteSpace(textBoxSweetType.Text))
                {
                    var sweet = _worker.FindBy(textBoxSweetType.Text);

                    if (radioButtonTextBox.IsChecked == true)
                    {
                        PrintSweet(sweet);
                    }
                    else if (radioButtonTreeView.IsChecked == true)
                    {
                        PrintSweetToTreeView(sweet);
                    }
                    else if (radioButtonListBox.IsChecked == true)
                    {
                        PrintSweetToListBox(sweet);
                    }
                    textBoxSweetType.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Введите название конфеты для поиска!!!");
                }
            }
            else
            {
                MessageBox.Show("Для начала откройте файл!!!");
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (IsFileOpened)
            {
                if (!string.IsNullOrEmpty(textBoxDeleteSweetType.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteSweetType.Text))
                {
                    _worker.Delete(textBoxDeleteSweetType.Text);
                    if (radioButtonTextBox.IsChecked == true)
                    {
                        PrintSweet(_worker.GetAll());
                    }
                    else if (radioButtonTreeView.IsChecked == true)
                    {
                        PrintSweetsToTreeView(_worker.GetAll());
                    }
                    else if (radioButtonListBox.IsChecked == true)
                    {
                        PrintSweetsToListBox(_worker.GetAll());
                    }
                }
                else
                {
                    MessageBox.Show("Введите название сладости для удаления!!!");
                }
            }
            else
            {
                MessageBox.Show("Для начала откройте файл!!!");
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (IsFileOpened)
            {
                var addSweetForm = new AddSweetWindow();

                var result = addSweetForm.ShowDialog();

                if (result.HasValue && result.Value)
                {
                    var newSweetType = addSweetForm.textBoxSweetType.Text;
                    var newSweetPrice = double.Parse(addSweetForm.textBoxSweetPrice.Text);

                    var newSweet = new Sweet { Type = newSweetType, Price = newSweetPrice };

                    _worker.Add(newSweet);

                    if (radioButtonTextBox.IsChecked == true)
                    {
                        PrintSweet(_worker.GetAll());
                    }
                    else if (radioButtonTreeView.IsChecked == true)
                    {
                        PrintSweetsToTreeView(_worker.GetAll());
                    }
                    else if (radioButtonListBox.IsChecked == true)
                    {
                        PrintSweetsToListBox(_worker.GetAll());
                    }
                }
            }
            else
            {
                MessageBox.Show("Для начала откройте файл!!!");
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PrintSweet(Sweet sweet)
        {
            textBlockXMLFileContent.Text = "======Sweet======" + Environment.NewLine;
            textBlockXMLFileContent.Text += sweet?.ToString() ?? "Sweet not found";
        }

        private void PrintSweet(List<Sweet> sweets)
        {
            textBlockXMLFileContent.Text = "======Sweets======" + Environment.NewLine;
            foreach (var sweet in sweets)
            {
                textBlockXMLFileContent.Text += sweet.ToString();
            }
        }
        private void PrintSweetToTreeView(Sweet sweet)
        {
            treeViewXMLFileContent.Items.Clear();

            if (sweet != null)
            {
                TreeViewItem sweetNode = new TreeViewItem();
                sweetNode.Header = "Sweet: " + sweet.Type;

                TreeViewItem priceNode = new TreeViewItem();
                priceNode.Header = "Price: " + sweet.Price;
                sweetNode.Items.Add(priceNode);

                treeViewXMLFileContent.Items.Add(sweetNode);
                sweetNode.IsExpanded = true;
            }
        }

        private void PrintSweetsToTreeView(List<Sweet> sweets)
        {
            treeViewXMLFileContent.Items.Clear();

            foreach (var sweet in sweets)
            {
                TreeViewItem sweetNode = new TreeViewItem();
                sweetNode.Header = "Sweet: " + sweet.Type;

                TreeViewItem priceNode = new TreeViewItem();
                priceNode.Header = "Price: " + sweet.Price;
                sweetNode.Items.Add(priceNode);

                treeViewXMLFileContent.Items.Add(sweetNode);
                sweetNode.IsExpanded = true;

            }
        }

        private void PrintSweetToListBox(Sweet sweet)
        {
            listBoxXMLFileContent.Items.Clear();

            if (sweet != null)
            {
                listBoxXMLFileContent.Items.Add("Sweet: " + sweet.Type + ", Price: " + sweet.Price);
            }
        }

        private void PrintSweetsToListBox(List<Sweet> sweets)
        {
            listBoxXMLFileContent.Items.Clear();

            foreach (var sweet in sweets)
            {
                listBoxXMLFileContent.Items.Add("Sweet: " + sweet.Type + ", Price: " + sweet.Price);
            }
        }



        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                IsFileOpened = true;
                if (radioButtonTextBox.IsChecked == true)
                {
                    PrintSweet(_worker.GetAll());
                }
                else if (radioButtonTreeView.IsChecked == true)
                {
                    PrintSweetsToTreeView(_worker.GetAll());
                }
                else if (radioButtonListBox.IsChecked == true)
                {
                    PrintSweetsToListBox(_worker.GetAll());
                }
            }
        }

        private void RadioButtonChangeViewType(object sender, RoutedEventArgs e)
        {
            if (IsFileOpened)
            {
                if (radioButtonTextBox.IsChecked == true)
                {
                    PrintSweet(_worker.GetAll());
                }
                else if (radioButtonTreeView.IsChecked == true)
                {
                    PrintSweetsToTreeView(_worker.GetAll());
                }
                else if (radioButtonListBox.IsChecked == true)
                {
                    PrintToListBox(_worker.GetAll());
                }
            }

            if (radioButtonTextBox.IsChecked == true)
            {
                textBlockXMLFileContent.Visibility = Visibility.Visible;
                treeViewXMLFileContent.Visibility = Visibility.Collapsed;
                listBoxXMLFileContent.Visibility = Visibility.Collapsed;
            }
            else if (radioButtonTreeView.IsChecked == true)
            {
                textBlockXMLFileContent.Visibility = Visibility.Collapsed;
                treeViewXMLFileContent.Visibility = Visibility.Visible;
                listBoxXMLFileContent.Visibility = Visibility.Collapsed;
            }
            else if (radioButtonListBox.IsChecked == true)
            {
                textBlockXMLFileContent.Visibility = Visibility.Collapsed;
                treeViewXMLFileContent.Visibility = Visibility.Collapsed;
                listBoxXMLFileContent.Visibility = Visibility.Visible;
            }
        }

        private void PrintToListBox(List<Sweet> sweets)
        {
            throw new NotImplementedException();
        }
    }
}