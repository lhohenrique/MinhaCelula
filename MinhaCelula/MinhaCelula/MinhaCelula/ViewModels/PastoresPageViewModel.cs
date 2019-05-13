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
    public class PastoresPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Person> _pastoresList;
        public ObservableCollection<Person> PastoresList
        {
            get { return _pastoresList; }
            set { SetProperty(ref _pastoresList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddPastorButtonCommand { get; set; }
        public DelegateCommand<Person> SelectPastorButtonCommand { get; set; }
        #endregion

        public PastoresPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddPastorButtonCommand = new DelegateCommand(AddPastorButtonAction);
            SelectPastorButtonCommand = new DelegateCommand<Person>(SelectPastorButtonAction);

            PastoresList = PersonService.GetPersons();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddPastorButtonAction()
        {
            navigationService.NavigateAsync("AddEditPersonPage");
        }

        private void SelectPastorButtonAction(Person personSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("person", personSelected);

            navigationService.NavigateAsync("AddEditPersonPage", navigationParams);
        }
        #endregion
    }
}
