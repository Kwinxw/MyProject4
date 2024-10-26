using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Project4
{
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
            SetPlaceholder(InputA, "Введите A");
            SetPlaceholder(InputB, "Введите B");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.Foreground = System.Windows.Media.Brushes.Gray;
        }

        private void InputA_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputA.Text == "Введите A")
            {
                InputA.Text = "";
                InputA.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputA_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputA.Text))
            {
                SetPlaceholder(InputA, "Введите A");
            }
        }

        private void InputB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputB.Text == "Введите B")
            {
                InputB.Text = "";
                InputB.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputB.Text))
            {
                SetPlaceholder(InputB, "Введите B");
            }
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputA.Text, out int a) && int.TryParse(InputB.Text, out int b))
            {
                if (a < b)
                {
                    int sum = Enumerable.Range(a + 1, b - a - 1).Sum();
                    ResultText.Text = $"Сумма: {sum} Нечетные числа: {string.Join(", ", Enumerable.Range(a + 1, b - a - 1).Where(x => x % 2 != 0))}";
                }
                else
                {
                    MessageBox.Show("A должно быть меньше B.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные целые числа.");
            }
        }
    }
}
