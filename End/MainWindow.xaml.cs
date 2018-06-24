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

namespace End
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RiceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 米飯喜好數值
            double Value = Math.Round(RiceSlider.Value, 0);
            RiceNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Rice, v);

        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 麵食喜好數值
            double Value = Math.Round(NoodlesSlider.Value, 0);
            NoodlesNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Noodles, v);
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            int rice = int.Parse(RiceNumber.Text);
            int noodles = int.Parse(NoodlesNumber.Text);
            if (rice > noodles)
            {
                ResultShowing.Text = "ㄘ飯飯";
            }

        }
    }
}
