using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Xml.Linq;
using System.Xml;
namespace Task
{
    public partial class MainWindow : Window
    {
        private XDocument sweetXml;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddSweet_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text) || string.IsNullOrWhiteSpace(wrapperTextBox.Text) || string.IsNullOrWhiteSpace(costTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (sweetXml == null)
            {
                sweetXml = new XDocument(new XElement("Сладости"));
            }

            sweetXml.Root.Add(new XElement("Сладость",
                new XElement("Тип", typeTextBox.Text),
                new XElement("Обёртка", wrapperTextBox.Text),
                new XElement("Стоимость", costTextBox.Text)));

            sweetListBox.Items.Add(typeTextBox.Text);

            typeTextBox.Clear();
            wrapperTextBox.Clear();
            costTextBox.Clear();
        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                sweetXml = XDocument.Load(openFileDialog.FileName);
                sweetListBox.Items.Clear();
                foreach (XElement book in sweetXml.Root.Elements("Тип"))
                {
                    sweetListBox.Items.Add(book.Element("Обёртка").Value);
                }
            }
        }

       
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SearchSweet_Click(object sender, RoutedEventArgs e)
        {
            string searchTitle = searchTextBox.Text;
            var sweet = sweetXml.Root.Elements("Тип").FirstOrDefault(x => x.Element("Обёртка").Value == searchTitle);
            if (sweet != null)
            {
                MessageBox.Show($"Сладость найдена: {sweet.Element("Тип").Value}, {sweet.Element("Обёртка").Value}, {sweet.Element("Стоимость").Value}");
            }
            else
            {
                MessageBox.Show("Сладость не найдена.");
            }
        }

        private void DeleteSweet_Click(object sender, RoutedEventArgs e)
        {
            string deleteTitle = deleteTextBox.Text;
            var sweet = sweetXml.Root.Elements("Тип").FirstOrDefault(x => x.Element("Обёртка").Value == deleteTitle);
            if (sweet != null)
            {
                sweet.Remove();
                sweetListBox.Items.Remove(deleteTitle);
                MessageBox.Show("Сладость удалена.");
            }
            else
            {
                MessageBox.Show("Сладость не найдена.");
            }

        }
    }
}


        
    



   
