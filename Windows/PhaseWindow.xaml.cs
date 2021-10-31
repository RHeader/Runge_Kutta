using LiveCharts;
using LiveCharts.Defaults;
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
    /// Логика взаимодействия для PhaseWindow.xaml
    /// </summary>
    public partial class PhaseWindow : Window
    {
        public SeriesCollection SeriesCollection1 { get; set; }

        public List<string> LabelsX { get; set; }
        private ChartValues<ObservablePoint> LabelsPhase { get; set; }
        public Func<double, string> YFormatter { get; set; }
        private List<Data> DataKutta;
        public PhaseWindow(List<Data> data)
        {
            InitializeComponent();
            DataKutta = data;
            SeriesCollection1 = new SeriesCollection();
            LabelsX = new List<string>();
            LabelsPhase = new ChartValues<ObservablePoint>();
            foreach (Data point in DataKutta)
            {
                LabelsX.Add(point.step.ToString());
                LabelsPhase.Add(new ObservablePoint(point.Prey,point.Predator));
            }
            SeriesCollection1.Add(new LineSeries
            {
                Title = "Добыча и Хищники",
                Values = LabelsPhase,
                LineSmoothness = 1, 
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 1,
                PointForeground = Brushes.Blue
            });
            //modifying any series values will also animate and update the chart
            DataContext = this;
        }
    }
}
