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

namespace WPF_laba_25
{
    /// <summary>
    /// Логика взаимодействия для task1.xaml
    /// </summary>
    public partial class task1 : Page
    {
        private int workButtonClickCount = 0;

        public task1()
        {
            InitializeComponent();
        }

        private void Trap(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это зря", "Ужас", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Work(object sender, RoutedEventArgs e)
        {
            workButtonClickCount++;

            if (workButtonClickCount >= 2)
            {

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                Window.GetWindow(this).Close();
            }
            else
            {
                MessageBox.Show("Вы не маленький уже, нажмите вверху на стрелку, мне лень писать код\n\n\nА, что, если второй раз жмакнуть?)", "Лень", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
