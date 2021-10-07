using ModernDesign.MVVM.Model;
using ModernDesign.MVVM.View;
using ModernDesign.MVVM.ViewModel;
using ModernWpf.Controls;
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

namespace ModernDesign
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomeViewModel homeViewModel;
        public MainWindow()
        {
            InitializeComponent();
            HomeViewModel homeViewModel = new HomeViewModel();
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing,
            // otherwise assume the value got filled in by TextMemberPath
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                sender.ItemsSource = db.GetContext().books.Where(p => p.name.Contains(sender.Text)).ToList();
                //Set the ItemsSource to be your filtered dataset
                //sender.ItemsSource = dataset;
            }
        }


        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            (sender as AutoSuggestBox).Text = (args.SelectedItem as books).name;

            // Set sender.Text. You can use args.SelectedItem to build your text string.
            switch (Manager.currentRole)
            {
                case Manager.Role.Reader:
                    var examplar = (args.SelectedItem as books).examplar.FirstOrDefault();

                    if (examplar != null)
                        MessageBox.Show("Табельный номер: " + examplar.id_exemplar);
                    else
                        MessageBox.Show("Книги нет в наличии");
                    break;
                case Manager.Role.Worker:
                    new bookWindow(args.SelectedItem as books).ShowDialog();
                    break;
                default:
                    break;
            }
            

        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // Use args.QueryText to determine what to do.
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
