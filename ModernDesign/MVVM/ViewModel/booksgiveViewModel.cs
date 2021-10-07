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
    class booksgiveViewModel:ObservableObject
    {
        private bool _onlyWOVozvrat=false;

        public bool onlyWOVozvrat
        {
            get
            {
                return _onlyWOVozvrat;
            }
            set
            {
                _onlyWOVozvrat = value;
                if(value)
                {
                    Givenbooks = db.GetContext().kartoteka_chitatel.Where(p => p.date_vozvrat_book == null).ToList();
                }
                else
                {
                    Givenbooks = db.GetContext().kartoteka_chitatel.ToList();
                }
            }
        }

        public Action CloseAction { get; set; }

        private List<kartoteka_chitatel> _givenbooks;
        public List<kartoteka_chitatel> Givenbooks
        {
            get
            {
                return _givenbooks;
            }
            set
            {
                _givenbooks = value;
                OnPropertyChanged(nameof(Givenbooks));
            }
        }
        //public string nameUser { get; set; }

        public kartoteka_chitatel SelectedVkladish { get; set; }
        private RelayCommand _giveBookClick;
        public RelayCommand giveBookClick
        {
            get
            {
                return _giveBookClick ?? (_giveBookClick = new RelayCommand(obj =>
                {
                    new giveBookWindow().ShowDialog();
                    Givenbooks = db.GetContext().kartoteka_chitatel.ToList();
                    OnPropertyChanged(nameof(Givenbooks));
                }));
            }
        }

        public Visibility giveButtonVis
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
            }
        }


        public booksgiveViewModel()
        {
            this.Givenbooks = db.GetContext().kartoteka_chitatel.ToList();
            

        }

        private RelayCommand _giveBackClick;

        public RelayCommand giveBackClick
        {
            get
            {
                if (Manager.currentRole == Manager.Role.Worker)
                    return _giveBackClick ?? (_giveBackClick = new RelayCommand(obj =>
                    {
                        if(MessageBox.Show($"Вернуть {SelectedVkladish.examplar.books.name}?","Принять возврат",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        SelectedVkladish.dateVozvratNotified = DateTime.Now;
                    }));
                else
                    return null;
            }
        }

       
    }
}

