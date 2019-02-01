using MinhaCelula.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        #region Properties
        private string cellName;
        public string CellName
        {
            get { return cellName; }
            set { SetProperty(ref cellName, value); }
        }

        private string nextMeeting;
        public string NextMeeting
        {
            get { return nextMeeting; }
            set { SetProperty(ref nextMeeting, value); }
        }

        private string cellStartTime;
        public string CellStartTime
        {
            get { return cellStartTime; }
            set { SetProperty(ref cellStartTime, value); }
        }

        private ObservableCollection<Person> birthdaysOfMonthList;
        public ObservableCollection<Person> BirthdaysOfMonthList
        {
            get { return birthdaysOfMonthList; }
            set { SetProperty(ref birthdaysOfMonthList, value); }
        }
        #endregion

        #region Commands
        #endregion

        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            CellName = "MinhaCelula 1";
            NextMeeting = "15/05/2019";
            CellStartTime = "19 horas";
        }
    }
}
