using System;
using System.Windows;
using System.Windows.Controls;

namespace Project4
{
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
            SetPlaceholder(InputN, "Введите N");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.Foreground = System.Windows.Media.Brushes.Gray;
        }

        private void InputN_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputN.Text == "Введите N")
            {
                InputN.Text = "";
                InputN.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputN_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputN.Text))
            {
                SetPlaceholder(InputN, "Введите N");
            }
        }

        private void CalculateSum(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputN.Text, out int N) && N > 0)
            {
                int sum = (N * (N + 1)) / 2;
                ResultText.Text = $"Сумма: {sum}";
            }
            else
            {
                MessageBox.Show("Введите корректное положительное число.");
            }
        }
    }
}
