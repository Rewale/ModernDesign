using ModernDesign.MVVM.Model;
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

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для authWindow.xaml
    /// </summary>
    public partial class authWindow : Window
    {
        public authWindow()
        {
            InitializeComponent();
        }

        private void enter_as_reader_click(object sender, RoutedEventArgs e)
        {
            Manager.currentRole = Manager.Role.Reader;
            new MainWindow().Show();
            Close();
        }

        private void enter_as_worker_click(object sender, RoutedEventArgs e)
        {
            Manager.currentRole = Manager.Role.Worker;
            new MainWindow().Show();
            Close();
        }
    }
}
