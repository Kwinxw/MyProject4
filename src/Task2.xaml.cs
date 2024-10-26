using System.Linq;
using System.Windows;

namespace Project4
{
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void ShowSquares(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Join(", ", Enumerable.Range(10, 11).Select(x => x * x));
        }
    }
}
