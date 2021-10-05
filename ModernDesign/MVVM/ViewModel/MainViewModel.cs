using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel:ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DicoveryViewCommand { get; set; }
        public RelayCommand GivenBookViewCommand { get; }
        public RelayCommand SearchEnterACCommand { get; set;}
        public RelayCommand SearchChoosen { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DicoveryViewModel DicoveryVM { get; set; }
        public booksgiveViewModel booksgiveViewModel { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DicoveryVM = new DicoveryViewModel();
            booksgiveViewModel = new booksgiveViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DicoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DicoveryVM;
            });
            GivenBookViewCommand = new RelayCommand(o =>
            {
                CurrentView = booksgiveViewModel;
            });
        }
    }
}
