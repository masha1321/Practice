﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += ButtonRun_Click;
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Masha";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName.Text)
                || string.IsNullOrWhiteSpace(textBoxEnterName.Text))
            {
                input = "Hi!";
            }
            else
            {
                input = textBoxEnterName.Text;
            }
            textBlockHello.Text = $"{hello} {input}";
        }
    }
}
    

