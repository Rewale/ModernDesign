using ModernDesign.Core;
using ModernDesign.MVVM.Model;
using ModernDesign.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModernDesign.MVVM.ViewModel
{
    class HomeViewModel
    {
        public Action CloseAction { get; set; }
        public List<books> books { get; set; }
        public string nameUser { get; set; }

        public books SelectedBook { get; set; }
        //private Visibility _deleteButtonVisible;
        public Visibility deleteButtonVisible
        {
            get
            {
                switch (Manager.currentRole)
                {
                    case Manager.Role.Reader:
                        return Visibility.Hidden;
                    case Manager.Role.Worker:
                        return Visibility.Visible;
                    default:
                        return Visibility.Collapsed;
                }
                //return _deleteButtonVisible;
            }
        }

        public HomeViewModel()
        {
            this.books = db.GetContext().books.ToList();
            switch (Manager.currentRole)
            {
                case Manager.Role.Reader:
                    nameUser = "Читатель";
                    break;
                case Manager.Role.Worker:
                    nameUser = "Работник";
                    break;
                default:
                    break;
            }
            
        }

        private RelayCommand _deleteClick;

        public RelayCommand deleteClick
        {
            get
            {
                return _deleteClick ?? (_deleteClick = new RelayCommand(obj =>
                 {
                     db.GetContext().examplar.RemoveRange(SelectedBook.examplar);
                     db.GetContext().books.Remove(SelectedBook);
                     db.GetContext().SaveChanges();

                     MessageBox.Show("Удаление", "Удаление прошло успеншо");
                 }));
            }
        }

        private RelayCommand _doubleClickItem;

        public RelayCommand doubleClickItem
        {
            get
            {
                switch (Manager.currentRole)
                {
                    case Manager.Role.Reader:
                        return _doubleClickItem ??
                          (_doubleClickItem = new RelayCommand(obj =>
                          {
                              var examplar = SelectedBook.examplar.FirstOrDefault();

                              if (examplar != null)
                                  MessageBox.Show("Табельный номер: " + examplar.id_exemplar);
                              else
                                  MessageBox.Show("Книги нет в наличии");
                          }));
                    case Manager.Role.Worker:
                        return _doubleClickItem ??
                          (_doubleClickItem = new RelayCommand(obj =>
                          {
                              new bookWindow(SelectedBook).ShowDialog();

                          }));
                    default:
                        return null;
                }

            }
        }

        private RelayCommand _openWindowNew;

        public RelayCommand openWindowCommand
        {
            get
            {
                return _openWindowNew ?? (_openWindowNew = new RelayCommand(obj => {
                    new authWindow().Show();
                    CloseAction();
                }
                ));
            }
        }
    }
}
