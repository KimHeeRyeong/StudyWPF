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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        float nowNum = 0;
        float result = 0;
        char preOperator = '0';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(nowNum == 0)
            {
                this.tbResult.Text = btn.Content.ToString();
                nowNum = float.Parse(this.tbResult.Text);
            }
            else
            {
                this.tbResult.Text += btn.Content.ToString();
                nowNum = float.Parse(this.tbResult.Text);
            }
        }
        private void ForthRule_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            Button btn = (Button)sender;
            preOperator = btn.Content.ToString()[0];

            tbCal.Text += tbResult.Text + btn.Content.ToString();
            nowNum = 0;
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            this.tbResult.Text = result.ToString();
            this.tbCal.Text = "";
            preOperator = '0';
            nowNum = 0;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            preOperator = '0';
            this.tbResult.Text = "0";
            this.tbCal.Text = "";
            nowNum = 0;
            result = 0;
        }

        private void Calculate() {
            if (preOperator == '0')
            {
                result += nowNum;
            }
            else if (preOperator == '+')
            {
                result += nowNum;
            }
            else if (preOperator == '-')
            {
                result -= nowNum;
            }
            else if (preOperator == '*')
            {
                result *= nowNum;
            }
            else if (preOperator == '/')
            {
                result /= nowNum;
            }
        }
       
    }
}
