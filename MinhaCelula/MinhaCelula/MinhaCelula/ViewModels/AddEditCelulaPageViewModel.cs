using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class AddEditCelulaPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private string _pageTitle;
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private ObservableCollection<string> _LeaderList;
        public ObservableCollection<string> LeaderList
        {
            get { return _LeaderList; }
            set { SetProperty(ref _LeaderList, value); }
        }

        private TimeSpan _StartTime;
        public TimeSpan StartTime
        {
            get { return _StartTime; }
            set { SetProperty(ref _StartTime, value); }
        }

        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { SetProperty(ref _Country, value); }
        }

        private string _State;
        public string State
        {
            get { return _State; }
            set { SetProperty(ref _State, value); }
        }

        private string _City;
        public string City
        {
            get { return _City; }
            set { SetProperty(ref _City, value); }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { SetProperty(ref _Address, value); }
        }

        private string _selectLiderButtonText;
        public string SelectLiderButtonText
        {
            get { return _selectLiderButtonText; }
            set { SetProperty(ref _selectLiderButtonText, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand SaveButtonCommand { get; }
        public DelegateCommand SelectLiderButtonCommand { get; }
        #endregion

        public AddEditCelulaPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SaveButtonCommand = new DelegateCommand(SaveButtonAction);
            SelectLiderButtonCommand = new DelegateCommand(SelectLiderButtonAction);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            PageTitle = "Nova Célula";
        }

        private void SaveButtonAction()
        {
            
        }

        private void SelectLiderButtonAction()
        {
            navigationService.NavigateAsync("PersonPage");
        }
    }
}
