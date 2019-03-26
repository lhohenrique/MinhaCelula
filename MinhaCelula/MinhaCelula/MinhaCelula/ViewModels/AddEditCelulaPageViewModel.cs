using MinhaCelula.Models;
using MinhaCelula.Services;
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
        private Celula celula;

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

        //private ObservableCollection<string> _LeaderList;
        //public ObservableCollection<string> LeaderList
        //{
        //    get { return _LeaderList; }
        //    set { SetProperty(ref _LeaderList, value); }
        //}

        private ObservableCollection<Person> _membersList = new ObservableCollection<Person>();
        public ObservableCollection<Person> MembersList
        {
            get { return _membersList; }
            set { SetProperty(ref _membersList, value); }
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

        private string _selectAnfitriaoButtonText;
        public string SelectAnfitriaoButtonText
        {
            get { return _selectAnfitriaoButtonText; }
            set { SetProperty(ref _selectAnfitriaoButtonText, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand SaveButtonCommand { get; }
        public DelegateCommand SelectLiderButtonCommand { get; }
        public DelegateCommand SelectAnfitriaoButtonCommand { get; }
        public DelegateCommand AddMemberButtonCommand { get; }
        #endregion

        public AddEditCelulaPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SaveButtonCommand = new DelegateCommand(SaveButtonAction);
            SelectLiderButtonCommand = new DelegateCommand(SelectLiderButtonAction);
            SelectAnfitriaoButtonCommand = new DelegateCommand(SelectAnfitriaoButtonAction);
            AddMemberButtonCommand = new DelegateCommand(AddMemberButtonAction);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            ClearFields();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            celula = (Celula)parameters["celula"];

            if (celula != null)
            {
                PageTitle = "Editar";

                Name = celula.Name;
                StartTime = celula.CelulaStartTime;
                Country = celula.Country;
                State = celula.State;
                City = celula.City;
                Address = celula.Address;
                SelectLiderButtonText = celula.LeaderName;
                SelectAnfitriaoButtonText = celula.AnfitriaoName;

                foreach (Person member in celula.Members)
                {
                    MembersList.Add(member);
                }
            }
            else
            {
                PageTitle = "Nova Célula";
                SelectLiderButtonText = "Selectione o líder";
                SelectAnfitriaoButtonText = "Selectione o anfitrião";
            }            
        }

        #region Action
        private void SaveButtonAction()
        {
            
        }

        private void SelectLiderButtonAction()
        {
            navigationService.NavigateAsync("PersonsPage");
        }

        private void SelectAnfitriaoButtonAction()
        {
            navigationService.NavigateAsync("PersonsPage");
        }

        private void AddMemberButtonAction()
        {
            navigationService.NavigateAsync("PersonsPage");
        }
        #endregion

        #region Methods
        private void ClearFields()
        {
            PageTitle = string.Empty;

            Name = string.Empty;
            StartTime = TimeSpan.Zero;
            Country = string.Empty;
            State = string.Empty;
            City = string.Empty;
            Address = string.Empty;
            SelectLiderButtonText = "Selectione o líder";
            SelectAnfitriaoButtonText = "Selectione o anfitrião";
            MembersList = new ObservableCollection<Person>();
        }
        #endregion
    }
}
