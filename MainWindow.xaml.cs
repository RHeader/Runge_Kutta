using System.Collections.Generic;
using System.Windows;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using _1laba.Windows;

namespace _1laba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //https://github.com/nismakoto/Lotka-Volterra/blob/master/lotka_volterra.cc
        //Runge Kutta 
        void runge_kutta(ref double x, ref double y, double h)
        {
            double dx1, dx2, dx3, dx4, dy1, dy2, dy3, dy4;

            dx1 = PreyFunc(x, y);
            dy1 = PredatorFunc(x, y);
            dx2 = PreyFunc(x + (h / 2.0) * dx1, y + (h / 2.0) * dy1);
            dy2 = PredatorFunc(x + (h / 2.0) * dx1, y + (h / 2.0) * dy1);
            dx3 = PreyFunc(x + (h / 2.0) * dx2, y + (h / 2.0) * dy2);
            dy3 = PredatorFunc(x + (h / 2.0) * dx2, y + (h / 2.0) * dy2);
            dx4 = PreyFunc(x + h * dx3, y + h * dy3);
            dy4 = PredatorFunc(x + h * dx3, y + h * dy3);

            x += h * (dx1 + 2.0 * dx2 + 2.0 * dx3 + dx4) / 6.0;
            y += h * (dy1 + 2.0 * dy2 + 2.0 * dy3 + dy4) / 6.0;
        }
        //Prey fx Добыча
        private double PreyFunc(double x, double y)
        {
            return Alpha * x - Beta * x * y;
        }
        //Predator fy хищник
        private double PredatorFunc(double x, double y)
        {
            return -Gamma * y + Delta * x * y;
        }
        double Alpha, Beta, Gamma, Delta;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GraphicWindow window = new GraphicWindow();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        internal List<Data> data;
        private void Calculated_Click(object sender, RoutedEventArgs e)
        {
            data = new List<Data>();
            double prey, predator, time;
            double h = 0.01;//шаг
            //Берем данные из формы .
            if (!double.TryParse(t_Param.Text, out time)) time = 0; //Время
            if (!double.TryParse(V_Param.Text, out predator)) predator = 0; // Хищники 
            if (!double.TryParse(P_Param.Text, out prey)) prey = 0; //Жертвы
            if (!double.TryParse(a_Param.Text, out Alpha)) Alpha = 0;
            if (!double.TryParse(b_Param.Text, out Beta)) Beta = 0;
            if (!double.TryParse(c_Param.Text, out Gamma)) Gamma = 0;
            if (!double.TryParse(d_Param.Text, out Delta)) Delta = 0;

            for (double i = 0; i < time; i += h)
            {
                runge_kutta(ref prey, ref predator, h);
                data.Add(new Data { step = Math.Round(i,2), Predator = predator, Prey = prey });
            }
            this.DataContext = data;
        }
    }
    public class Data
    {
        public double step { get; set; }
        public double Prey { get; set; }
        public double Predator { get; set; }
    }
}
