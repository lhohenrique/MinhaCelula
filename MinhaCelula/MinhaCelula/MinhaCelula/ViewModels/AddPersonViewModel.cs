using MinhaCelula.Commons;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using static MinhaCelula.Models.Person;

namespace MinhaCelula.ViewModels
{
	public class AddPersonViewModel : BindableBase
	{
        #region Properties
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

        public AddPersonViewModel()
        {

        }
	}
}
