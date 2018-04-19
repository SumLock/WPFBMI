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

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //定義變數
                double H, W;
                H = Convert.ToInt32(height.Text);
                W = Convert.ToInt32(weight.Text);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                result.Text = (W / (h * h)).ToString();
            }
            //除錯,處理非數字例外情況
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
