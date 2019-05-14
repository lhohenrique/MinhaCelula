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
    public class MembrosPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Person> _membrosList;
        public ObservableCollection<Person> MembrosList
        {
            get { return _membrosList; }
            set { SetProperty(ref _membrosList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddMembroButtonCommand { get; set; }
        public DelegateCommand<Person> SelectMembroButtonCommand { get; set; }
        #endregion

        public MembrosPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddMembroButtonCommand = new DelegateCommand(AddMembroButtonAction);
            SelectMembroButtonCommand = new DelegateCommand<Person>(SelectMembroButtonAction);

            MembrosList = PersonService.GetPersons();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddMembroButtonAction()
        {
            navigationService.NavigateAsync("AddEditPersonPage");
        }

        private void SelectMembroButtonAction(Person personSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("person", personSelected);

            navigationService.NavigateAsync("AddEditPersonPage", navigationParams);
        }
        #endregion
    }
}
