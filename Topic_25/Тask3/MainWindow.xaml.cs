using System;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChartAxisStep = 0.2;
            Values = new ChartValues<ObservablePoint>();
            for (double x = -10; x <= 10; x += ChartAxisStep)
            {
                Values.Add(new ObservablePoint(x, (1 / x)));
            }

            LineSeries.Values = Values;
        }

        public ChartValues<ObservablePoint> Values { get; set; }
        public double ChartAxisStep { get; set; }
    }
}
