﻿using MinhaCelula.Models;
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
    public class PersonsPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Person> _personsList;
        public ObservableCollection<Person> PersonsList
        {
            get { return _personsList; }
            set { SetProperty(ref _personsList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddPersonButtonCommand { get; set; }
        #endregion

        public PersonsPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddPersonButtonCommand = new DelegateCommand(AddPersonButtonAction);

            PersonsList = PersonService.GetPersons();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddPersonButtonAction()
        {
            navigationService.NavigateAsync("AddEditPersonPage");
        }
        #endregion
    }
}
