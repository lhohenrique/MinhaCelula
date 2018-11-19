using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class AddChurchViewModel : BindableBase
	{
        #region Properties
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private string _PastorName;
        public string PastorName
        {
            get { return _PastorName; }
            set { SetProperty(ref _PastorName, value); }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { SetProperty(ref _Phone, value); }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
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
        #endregion

        #region Commands
        public DelegateCommand AddChurchCommand { get; }
        #endregion

        public AddChurchViewModel()
        {
            AddChurchCommand = new DelegateCommand(AddChurchAction);
        }

        private void AddChurchAction()
        {

        }
	}
}
