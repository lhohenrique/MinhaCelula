using MinhaCelula.Commons;
using MinhaCelula.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using static MinhaCelula.Models.Person;

namespace MinhaCelula.ViewModels
{
	public class AddEditPersonPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;
        private Person person;

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

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { SetProperty(ref _Phone, value); }
        }

        private DateTime _Birthday;
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { SetProperty(ref _Birthday, value); }
        }

        private PersonProfile _Profile;
        public PersonProfile Profile
        {
            get { return _Profile; }
            set { SetProperty(ref _Profile, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand SaveButtonCommand { get; }
        #endregion

        public AddEditPersonPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SaveButtonCommand = new DelegateCommand(SaveButtonAction);

            PageTitle = "Add Person";
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            ClearFields();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            person = (Person)parameters["person"];

            if (person != null)
            {
                PageTitle = "Editar";

                Name = person.Name;
                Email = person.Email;
                Phone = person.Phone;
                Birthday = person.Birthday;
            }
            else
            {
                PageTitle = "Nova Pessoa";
            }
        }

        #region Action
        private void SaveButtonAction()
        {

        }
        #endregion

        #region Methods
        private void ClearFields()
        {
            PageTitle = string.Empty;

            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Birthday = DateTime.MinValue;
        }
        #endregion
    }
}
