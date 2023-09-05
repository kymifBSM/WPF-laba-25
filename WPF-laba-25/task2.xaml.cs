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
    /// Логика взаимодействия для task2.xaml
    /// </summary>
    public partial class task2 : Page
    {
        public task2()
        {
            InitializeComponent();
        }

        private void TB_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["LargeTextBoxStyle"];
        }

        private void TB_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["SmallTextBoxStyle"];
        }
    }
}
