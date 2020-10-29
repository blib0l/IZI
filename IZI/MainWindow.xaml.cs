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

namespace IZI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string myHost = System.Net.Dns.GetHostName();//получаем имя ПК

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox.Text = myHost;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(myHost).AddressList[0];
            textBox1.Text = Convert.ToString(ip);
        }
    }
}
