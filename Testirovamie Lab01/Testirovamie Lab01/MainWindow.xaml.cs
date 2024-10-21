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

namespace Testirovamie_Lab01
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

        private void click_Click(object sender, RoutedEventArgs e)
        {
            double num_1, num_2, num_3;
            
            if (number_1.Text == "")
            {
                result.Text = "Вы не ввели 1 сторону\n";
                return;
            }
            if(number_2.Text == "")
            {
                result.Text = "Вы не ввели 2 сторону\n";
                return;
            }
            if(number_3.Text == "")
            {
                result.Text = "Вы не ввели 3 сторону\n";
                return;
            }

            num_1 = Convert.ToDouble(number_1.Text);
            num_2 = Convert.ToDouble(number_2.Text);
            num_3 = Convert.ToDouble(number_3.Text);

            if (((num_1 + num_2) > num_3) && ((num_2 + num_3) > num_1) && ((num_1 + num_3) > num_2))
            {
                result.Text = "";
            }
            else
            {
                result.Text = "";
                result.Text = "Такого треугольника не существует!";
                return;
            }

            if (num_1 <= 0 || num_2 <= 0 || num_3 <= 0)
            {
                result.Text = "";
                result.Text = "Ошибка!(<= 0)\n";
                return;
            }

            if (num_1 == num_2 && num_2 == num_3) {
                result.Text = "";
                result.Text = "Треугольник равносторонний";
                return;
            }
            else if (num_1 == num_2 || num_2 == num_3 || num_1 == num_3)
            {
                result.Text = "";
                result.Text = "Треугольник равнобедренный";
                return;
            }
            else
            {
                result.Text = "";
                result.Text = "Треугольник разносторонний";
                return;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            number_1.Clear();
            number_2.Clear();
            number_3.Clear();
            result.Text = "";
        }
    }
}
