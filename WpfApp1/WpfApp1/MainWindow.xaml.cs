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
        string preNumStr ="";
        string nowNumStr = "";
        float result = 0;
        float preResult = 0;
        char preOperator = '0';
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (preOperator == '0')
            {
                nowNumStr += btn.Content.ToString();
                result = float.Parse(nowNumStr);
                this.tbResult.Text = (result).ToString();
            }
            else if (preOperator == '+')
            {
                nowNumStr += btn.Content.ToString();
                result = preResult+float.Parse(nowNumStr);
                this.tbCal.Text += btn.Content.ToString();
                this.tbResult.Text = (result).ToString();
            }
            else if (preOperator == '-')
            {
                nowNumStr += btn.Content.ToString();
                result = preResult - float.Parse(nowNumStr);
                this.tbCal.Text += btn.Content.ToString();
                this.tbResult.Text = (result).ToString();
            }
            else if (preOperator == '*')
            {
                nowNumStr += btn.Content.ToString();
                result = preResult * float.Parse(nowNumStr);
                this.tbCal.Text += btn.Content.ToString();
                this.tbResult.Text = (result).ToString();
            }
            else if (preOperator == '/')
            {
                nowNumStr += btn.Content.ToString();
                result = preResult / float.Parse(nowNumStr);
                this.tbCal.Text += btn.Content.ToString();
                this.tbResult.Text = (result).ToString();
            }

        }

        private void ForthRule_Click(object sender, RoutedEventArgs e)
        {
            preNumStr = nowNumStr;
            nowNumStr = "";
            Button btn = (Button)sender;
            preOperator = btn.Content.ToString()[0];
            if(tbCal.Text == "") {
                if(result == 0)
                {
                    this.tbCal.Text += "0 " + btn.Content.ToString() +" ";
                }
                else { this.tbCal.Text += result.ToString() + " " + btn.Content.ToString() + " "; }
            }else if(preNumStr == "")
            {
                this.tbCal.Text += "0 " + btn.Content.ToString() + " ";
            } else
            {
                this.tbCal.Text += " " + btn.Content.ToString() + " ";
            }
            preResult = result;
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            this.tbCal.Text = "";
            preResult = result;
            preNumStr = "";
            nowNumStr = "";
            preOperator = '0';
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            preOperator = '0';
            this.tbResult.Text = "0";
            this.tbCal.Text = "";
            preNumStr = "";
            nowNumStr = "";
            preResult = 0;
            result = 0;
        }
    }
}
