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
using System.Text.RegularExpressions;

namespace Pract11_Eliseev
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


        private void plusClick(object sender, RoutedEventArgs e)
        {
            string s = "2+3 223 2223";
            MessageBox.Show(s);
            Regex regex = new Regex(@"2+3");
            Match match = regex.Match(s);
            MessageBox.Show(match.ToString());

            //var answer = new StringBuilder();
            //foreach (var item in matches)
            //{
            //    answer.AppendLine(item.ToString());
            //}
            //MessageBox.Show(answer.ToString()); 
        }

        private void abbaClick(object sender, RoutedEventArgs e)
        {
            string s = "aa aba abba abbba abbbba abbbbba";
            MessageBox.Show(s);
            Regex regex = new Regex("abba, abbba, abbbba");

        }
    }
}
