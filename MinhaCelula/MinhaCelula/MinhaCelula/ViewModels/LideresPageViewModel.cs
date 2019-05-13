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
    public class LideresPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Person> _lideresList;
        public ObservableCollection<Person> LideresList
        {
            get { return _lideresList; }
            set { SetProperty(ref _lideresList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddLiderButtonCommand { get; set; }
        public DelegateCommand<Person> SelectLiderButtonCommand { get; set; }
        #endregion

        public LideresPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddLiderButtonCommand = new DelegateCommand(AddLiderButtonAction);
            SelectLiderButtonCommand = new DelegateCommand<Person>(SelectLiderButtonAction);

            LideresList = PersonService.GetPersons();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddLiderButtonAction()
        {
            navigationService.NavigateAsync("AddEditPersonPage");
        }

        private void SelectLiderButtonAction(Person personSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("person", personSelected);

            navigationService.NavigateAsync("AddEditPersonPage", navigationParams);
        }
        #endregion
    }
}
