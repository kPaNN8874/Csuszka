using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2023_02_01
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

        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(
                Color.FromRgb(
                    Convert.ToByte(sliPiros.Value),
                    Convert.ToByte(sliZold.Value),
                    Convert.ToByte(sliKek.Value)));
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            String szinAdatok = $"{Convert.ToString(sliPiros.Value)} ; ";
        }
    }
}
