using MinhaCelula.Models;
using MinhaCelula.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.ViewModels
{
    public class CoordenadoresPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Person> _coordenadoresList;
        public ObservableCollection<Person> CoordenadoresList
        {
            get { return _coordenadoresList; }
            set { SetProperty(ref _coordenadoresList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddCoordenadorButtonCommand { get; set; }
        public DelegateCommand<Person> SelectCoordenadorButtonCommand { get; set; }
        #endregion

        public CoordenadoresPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddCoordenadorButtonCommand = new DelegateCommand(AddCoordenadorButtonAction);
            SelectCoordenadorButtonCommand = new DelegateCommand<Person>(SelectCoordenadorButtonAction);

            CoordenadoresList = PersonService.GetPersons();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddCoordenadorButtonAction()
        {
            navigationService.NavigateAsync("AddEditPersonPage");
        }

        private void SelectCoordenadorButtonAction(Person personSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("person", personSelected);

            navigationService.NavigateAsync("AddEditPersonPage", navigationParams);
        }
        #endregion
    }
}
