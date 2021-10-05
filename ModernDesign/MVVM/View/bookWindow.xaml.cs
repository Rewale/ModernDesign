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
    /// Логика взаимодействия для bookWindow.xaml
    /// </summary>
    public partial class bookWindow : Window
    {
        bool isEdit = true;
        //public int exempCount { get; set; }

        public bookWindow(books book)
        {
            InitializeComponent();
            DataContext = book;
        }

        public bookWindow()
        {
            InitializeComponent();
            isEdit = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {   
                if(!isEdit)
                    db.GetContext().books.Add(DataContext as books);
                db.GetContext().SaveChanges();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "123",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var book = (DataContext as books);
            int count = int.Parse(countEx.Text);
            for (int i = 0; i < count; i++)
            {
                var exm = new examplar() { books=book};
                db.GetContext().examplar.Add(exm);
            }
            try
            {                
                db.GetContext().SaveChanges();
            }
            catch
            {
                MessageBox.Show("error", "error");
            }
            
        }
    }
}
