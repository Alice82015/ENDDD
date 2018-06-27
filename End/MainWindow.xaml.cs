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

        private void PorkSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 豬肉喜好數值
            double Value = Math.Round(PorkSlider.Value, 0);
            PorkNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Pork, v);
        }

        private void ChickenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 雞肉喜好數值
            double Value = Math.Round(ChickenSlider.Value, 0);
            ChickenNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Chicken, v);
        }

        private void BeefSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 牛肉喜好數值
            double Value = Math.Round(BeefSlider.Value, 0);
            BeefNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Beef, v);
        }

        private void DumplingsSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 水餃喜好數值
            double Value = Math.Round(DumplingsSlider.Value, 0);
            DumplingsNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Dumplings, v);
        }

        private void CabbageSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 高麗菜喜好數值
            double Value = Math.Round(CabbageSlider.Value, 0);
            CabbageNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Cabbage, v);
        }

        private void AmaranthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 韭菜喜好數值
            double Value = Math.Round(AmaranthSlider.Value, 0);
            AmaranthNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Amaranth, v);
        }

        private void FishMeatSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 魚肉喜好數值
            double Value = Math.Round(FishMeatSlider.Value, 0);
            FishMeatNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(FishMeat, v);
        }

        // 計算結果
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            int rice = int.Parse(RiceNumber.Text);
            int noodles = int.Parse(NoodlesNumber.Text);
            int pork = int.Parse(PorkNumber.Text);
            int chicken = int.Parse(ChickenNumber.Text);
            int beef = int.Parse(BeefNumber.Text);
            int dumplings = int.Parse(DumplingsNumber.Text);
            int cabbage = int.Parse(CabbageNumber.Text);
            int amaranth = int.Parse(AmaranthNumber.Text);
            int fishMeat = int.Parse(FishMeatNumber.Text);

            if (rice > noodles && rice > dumplings)
            {
                if (pork > chicken && pork > beef && pork > fishMeat)
                    ResultShowing.Text = "日式豚丼";

                else if (chicken > pork && chicken > beef && chicken > fishMeat)
                    ResultShowing.Text = "海南雞飯";

                else if (beef > pork && beef > chicken && beef > fishMeat)
                    ResultShowing.Text = "清燉牛肉粥";

                else
                    ResultShowing.Text = "香煎魚排飯";
            }
            if (noodles > rice && noodles > dumplings)
            {
                if (pork > chicken && pork > beef && pork > fishMeat)
                    ResultShowing.Text = "東京豚骨拉麵";

                else if (chicken > pork && chicken > beef && chicken > fishMeat)
                    ResultShowing.Text = "一品花雕雞麵";

                else if (beef > pork && beef > chicken && beef > fishMeat)
                    ResultShowing.Text = "紅燒牛肉麵";

                else
                    ResultShowing.Text = "炒鱔魚意麵";
            }
            if (dumplings > rice && dumplings > noodles)
            {
                if (cabbage > amaranth && cabbage > fishMeat)
                    ResultShowing.Text = "高麗菜水餃";

                else if (amaranth > cabbage && amaranth > fishMeat)
                    ResultShowing.Text = "韭菜水餃";

                else
                    ResultShowing.Text = "鮮魚肉水餃";
            }

            // 出錯顯示；數值等於0不能計算
            int[] food = { rice, noodles, pork, chicken, beef, dumplings, cabbage, amaranth, fishMeat };

            for (int i = 0; i < food.Length; i++)
            {
                if (food[i] == 0)
                {
                    MessageBox.Show("請使每件食材喜好程度值不為零以便精密計算。");
                    ResultShowing.Text = "-晚餐沒著落-";

                    break;
                }
            }
        }
    }
}
