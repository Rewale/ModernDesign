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
            chitsBox.ItemsSource = db.GetContext().chitatelskii_bilet.Where(p => p.kartoteka_chitatel.Count < 5).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var zapis = new kartoteka_chitatel();
            var bilet = chitsBox.SelectedItem as chitatelskii_bilet;
            var book = booksBox.SelectedItem as books;

            zapis.chitatelskii_bilet = chitsBox.SelectedItem as chitatelskii_bilet;
            zapis.date_vidachi_book = DateTime.Now;
            zapis.examplar = book.examplar.First();

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
    }
}
