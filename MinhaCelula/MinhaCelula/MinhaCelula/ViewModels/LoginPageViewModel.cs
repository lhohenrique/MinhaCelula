using MinhaCelula.Models;
using MinhaCelula.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinhaCelula.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        #region Properties
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand LoginCommand { get; set; }
        #endregion

        public LoginPageViewModel(INavigationService navigationService) : base (navigationService)
        {
            LoginCommand = new DelegateCommand(LoginAction);
        }

        private void LoginAction()
        {
            var isEmailValid = ValidateEmail();
            var isPasswordValid = ValidatePassword();

            if(isEmailValid && isPasswordValid)
            {
                var user = PersonService.GetUserByEmailAndPassword(Email, Password);

                if (user != null)
                {
                    NavigationService.NavigateAsync("MainPage");
                }
            }
            else
            {
                // Notify the user that the email or the password is wrong
            }
        }

        private bool ValidateEmail()
        {
            bool isEmailValid = false;

            if (!string.IsNullOrEmpty(Email))
                isEmailValid = true;

            return isEmailValid;
        }

        private bool ValidatePassword()
        {
            bool isPasswordValid = false;

            if (!string.IsNullOrEmpty(Password))
                isPasswordValid = true;

            return isPasswordValid;
        }
    }
}
