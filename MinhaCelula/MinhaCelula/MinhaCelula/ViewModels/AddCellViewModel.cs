using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class AddCellViewModel : BindableBase
	{
        #region Properties
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private ObservableCollection<string> _LeaderList;
        public ObservableCollection<string> LeaderList
        {
            get { return _LeaderList; }
            set { SetProperty(ref _LeaderList, value); }
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
        #endregion

        #region Commands
        public DelegateCommand AddCelulaCommand { get; }
        #endregion

        public AddCellViewModel()
        {
            AddCelulaCommand = new DelegateCommand(AddCelulaAction);
        }

        private void AddCelulaAction()
        {
            
        }
    }
}
