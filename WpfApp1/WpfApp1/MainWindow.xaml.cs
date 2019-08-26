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
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtChange_Click(object sender, RoutedEventArgs e)
        {
            this.btChange.Content = "눌렀다!";
        }

        private void BtEnter_Click(object sender, RoutedEventArgs e)
        {
            this.btEnter.Content = this.tbName.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TestWindow window = new TestWindow();
            bool? check = window.ShowDialog();//show는 새창 show dialog는 종속]
            if (check==true)
            {
                this.tbName.Text = window.btName.Content.ToString();
            }
            else
            {
            }
            
        }
    }
}
