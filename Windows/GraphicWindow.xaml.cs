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
using System.Linq;
namespace _1laba.Windows
{
    /// <summary>
    /// Логика взаимодействия для GraphicWindow.xaml
    /// </summary>
    public partial class GraphicWindow : Window
    {
        public SeriesCollection SeriesCollection1 { get; set; }
  
        public List<string> LabelsX { get; set; }
        private ChartValues<double> LabelsYPrey { get; set; }
        private ChartValues<double> LabelsYPredator { get; set; }
        public Func<double, string> YFormatter { get; set; }
        private List<Data> DataKutta;
        public GraphicWindow(List<Data> data)
        {
            InitializeComponent();
            DataKutta = data;
            SeriesCollection1 = new SeriesCollection();
            LabelsX = new List<string>();
            LabelsYPrey = new ChartValues<double>();
            LabelsYPredator = new ChartValues<double>();
            foreach (Data point in DataKutta)
            {
                LabelsX.Add(point.step.ToString());
                LabelsYPrey.Add(point.Prey);
                LabelsYPredator.Add(point.Predator);
            }
            YFormatter = value => value + ", секунд";

            //modifying the series collection will animate and update the chart
            SeriesCollection1.Add(new LineSeries
            {
                Title = "Добыча",
                Values = LabelsYPrey,
                LineSmoothness = 1, //0: straight lines, 1: really smooth lines
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 1,
                
                PointForeground = Brushes.Blue
            });
            SeriesCollection1.Add(new LineSeries
            {
                Title = "Хищники",
                Values = LabelsYPredator,
                LineSmoothness = 1, //0: straight lines, 1: really smooth lines
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 1,
                PointForeground = Brushes.Red
            });
            
            //modifying any series values will also animate and update the chart

            DataContext = this;
        }
    }
}
