using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = !ConfirmExit();
        }
        private bool ConfirmExit()
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Подтвердите выход", MessageBoxButton.YesNo, MessageBoxImage.Question);

            return result == MessageBoxResult.Yes;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double x, y;
            if (!double.TryParse(TextBox1.Text, out x) || !double.TryParse(TextBox2.Text, out y))
            {
                MessageBox.Show("Ошибка! Введите корректные числа");
                return;
            }
            double res = 0;

            if (sh.IsChecked == true)
            {
                if (x * y > 0)
                {
                    res = Math.Pow(Math.Sinh(x) + y, 2) - Math.Sqrt(Math.Sinh(x) * y);
                }
                else if (x * y < 0)
                {
                    res = Math.Pow(Math.Sinh(x) + y, 2) - Math.Sqrt(Math.Abs(Math.Sinh(x) * y));
                }
                else
                {
                    res = Math.Pow(Math.Sinh(x) + y, 2) + 1;
                }
                answer.Text = Convert.ToString(res);
            }
            else if (epsilon.IsChecked == true)
            {
                if (x * y > 0)
                {
                    res = Math.Pow(Math.Exp(x) + y, 2) - Math.Sqrt(Math.Exp(x) * y);
                }
                else if (x * y < 0)
                {
                    res = Math.Pow(Math.Exp(x) + y, 2) - Math.Sqrt(Math.Abs(Math.Exp(x) * y));
                }
                else
                {
                    res = Math.Pow(Math.Exp(x) + y, 2) + 1;
                }
                answer.Text = Convert.ToString(res);

            }
            else if (square.IsChecked == true)
            {
                if (x * y > 0)
                {
                    res = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Sqrt(Math.Pow(x, 2) * y);
                }
                else if (x * y < 0)
                {
                    res = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
                }
                else
                {
                    res = Math.Pow(Math.Pow(x, 2) + y, 2) + 1;
                }
                answer.Text = Convert.ToString(res);
            }
            else

            {
                MessageBox.Show("Ошибка! Укажите вид f(x)");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            answer.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void answer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}

