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
    /// Interaction logic for WindowCommand.xaml
    /// </summary>
    public partial class WindowCommand : Window
    {
        public WindowCommand()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            DoNew();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            DoNew();
        }

        private void DoNew()
        {
            MessageBox.Show("New File will be created!!!");
        }

        private void CommandBindingOpen_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            DoOpen();
        }

        private void CommandBindingOpen_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DoOpen()
        {
            MessageBox.Show("File will be opened!!!", "File Open Command", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }


        private void Save()
        {
            MessageBox.Show("File Saved!!!", "Save Command", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void CommandBindingSave_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Save();
        }

        private void CommandBindingSave_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
