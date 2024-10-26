using System.Windows;

namespace Project4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTask1(object sender, RoutedEventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void OpenTask2(object sender, RoutedEventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void OpenTask3(object sender, RoutedEventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void OpenTask4(object sender, RoutedEventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
        }
    }
}
