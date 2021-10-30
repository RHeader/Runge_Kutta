using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _1laba.Windows
{
    /// <summary>
    /// Логика взаимодействия для GraphicWindow.xaml
    /// </summary>
    public partial class GraphicWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        private List<string> LabelsX { get; set; }
        private ChartValues<double> LabelsYPrey { get; set; }
        private ChartValues<double> LabelsYPredator { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public List<Data> DataKutta;
        public GraphicWindow(List<Data> data)
        {
            InitializeComponent();
            DataKutta = data;
            SeriesCollection = new SeriesCollection();
            LabelsX = new List<string>();
            LabelsYPrey = new ChartValues<double>();
            LabelsYPredator = new ChartValues<double>();
            foreach (Data point in DataKutta)
            {
                LabelsX.Add(point.step.ToString());
                LabelsYPrey.Add(point.Prey);
                LabelsYPredator.Add(point.Predator);
            }
            //YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            SeriesCollection.Add(new LineSeries
            {
                Title = "Prey",
                Values = LabelsYPrey,
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 1,
                
                PointForeground = Brushes.Blue
            });
            SeriesCollection.Add(new LineSeries
            {
                Title = "Predator",
                Values = LabelsYPredator,
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 1,

                PointForeground = Brushes.Red
            });

            //modifying any series values will also animate and update the chart
            //SeriesCollection[3].Values.Add(5d);

            DataContext = this;
        }
    }
}
