using System;
using System.Windows;
using System.Windows.Controls;

namespace Project4
{
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
            SetPlaceholder(InputYears, "Введите - выслугу лет");
            SetPlaceholder(InputSalary, "Введите - зарплату");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.Foreground = System.Windows.Media.Brushes.Gray;
        }

        private void InputYears_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputYears.Text == "Введите - выслугу лет")
            {
                InputYears.Text = "";
                InputYears.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputYears_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputYears.Text))
            {
                SetPlaceholder(InputYears, "Введите - выслугу лет");
            }
        }

        private void InputSalary_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputSalary.Text == "Введите - зарплату")
            {
                InputSalary.Text = "";
                InputSalary.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputSalary_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputSalary.Text))
            {
                SetPlaceholder(InputSalary, "Введите - зарплату");
            }
        }

        private void CalculateBonus(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputYears.Text, out int years) && decimal.TryParse(InputSalary.Text, out decimal salary))
            {
                decimal bonusPercentage;

                if (years < 5) bonusPercentage = 0.10m;
                else if (years < 10) bonusPercentage = 0.15m;
                else if (years < 15) bonusPercentage = 0.25m;
                else if (years < 20) bonusPercentage = 0.35m;
                else if (years < 25) bonusPercentage = 0.45m;
                else bonusPercentage = 0.50m;

                decimal bonus = salary * bonusPercentage;
                ResultText.Text = $"Премия: {bonus:C}";
            }
            else
            {
                MessageBox.Show("Введите корректные данные.");
            }
        }
    }
}
