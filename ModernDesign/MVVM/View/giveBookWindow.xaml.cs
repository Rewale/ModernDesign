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
    /// Логика взаимодействия для giveBookWindow.xaml
    /// </summary>
    public partial class giveBookWindow : Window
    {
        public giveBookWindow()
        {
            InitializeComponent();
            booksBox.ItemsSource = db.GetContext().books.Where(p => p.examplar.Where(g=>g.kartoteka_chitatel.Count == 0).Count() > 0).ToList();
            chitsBox.ItemsSource = db.GetContext().chitatelskii_bilet.Where(p => p.kartoteka_chitatel.Where(g=>g.date_vozvrat_book == null).Count() < 5).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var zapis = new kartoteka_chitatel();
            var bilet = chitsBox.SelectedItem as chitatelskii_bilet;
            var book = booksBox.SelectedItem as books;

            zapis.chitatelskii_bilet = chitsBox.SelectedItem as chitatelskii_bilet;
            zapis.date_vidachi_book = DateTime.Now;
            zapis.examplar = exmpBox.SelectedItem as examplar;

            try
            {
                db.GetContext().kartoteka_chitatel.Add(zapis);
                db.GetContext().SaveChanges();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
                //throw;
            }
        }
        

        private void booksBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var book = (booksBox.SelectedItem as books);
            exmpBox.ItemsSource = db.GetContext().examplar.Where(p => p.books.id_book == book.id_book && p.kartoteka_chitatel.Count == 0).ToList();
        }
    }
}
