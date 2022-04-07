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
using System.Windows.Shapes;

namespace Week13Day4Demo
{
    /// <summary>
    /// Interaction logic for WindowExceptionHandling.xaml
    /// </summary>
    public partial class WindowExceptionHandling : Window
    {
        public WindowExceptionHandling()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            s.Trim();
        }
    }
}
