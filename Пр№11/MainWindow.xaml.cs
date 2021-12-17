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

namespace Пр_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindFirst_Click(object sender, RoutedEventArgs e)
        {
            string firstLine = "23  2+3  2++3  2+++3  445  677";
            first.Text = firstLine;
            Regex regex = new Regex(@"\b2\+*3\b");
            MatchCollection matches = regex.Matches(firstLine);
            if(matches.Count>0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                FirstListBox.ItemsSource = mas;

            }
        }

        private void FindSecond_Click(object sender, RoutedEventArgs e)
        {
            string secondLine = "*+  *q+  *qq+  *qqq+  *qqq  qqq+";
            second.Text = secondLine;
            Regex regex = new Regex(@"\*q*\+");
            MatchCollection matches = regex.Matches(secondLine);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                SecondListBox.ItemsSource = mas;

            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №11\nВыполнил студент группы ИСП-31 Обухов Сергей\nЗадание:\nДана строка '23 2+3 2++3 2+++3 445 677'. Напишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные.\nДана строка '*+ *q+ *qq+ *qqq+ *qqq qqq+'.Напишите регулярное выражение, которое найдет строки *q+, *qq+, *qqq+, не захватив остальные.", "Доп.Информация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
