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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_clck_1(object sender, RoutedEventArgs e)
        {
            task1 t1 = new task1();
            NavigationService.Navigate(t1);
        }

        private void btn_clck_2(object sender, RoutedEventArgs e)
        {
            task2 t2 = new task2();
            NavigationService.Navigate(t2);
        }
    }
}
