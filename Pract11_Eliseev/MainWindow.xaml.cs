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
            Regex regex = new Regex(@"2\+3");
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
            Regex regex = new Regex(@"ab{2,}a");
            MatchCollection match = regex.Matches(s);
            var str = new StringBuilder();
            foreach (Match m in match)
            {
                str.AppendLine(m.ToString());
            }
            MessageBox.Show(str.ToString());
        }

        private void aboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Елисеев Данила ИСП-31. \n Дана строка '2+3 223 2223'. Напишите регулярное выражение, " +
                "которое найдет строку 2+3, не захватив остальные.\n Дана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение, " +
                "\n которое найдет строки abba, abbba, abbbba и только их.");
        }
    }
}
