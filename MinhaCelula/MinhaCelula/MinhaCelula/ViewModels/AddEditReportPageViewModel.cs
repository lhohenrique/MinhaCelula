using MinhaCelula.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class AddEditReportPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;
        private Report report;

        #region Properties
        private string _pageTitle;
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private string _celulaName;
        public string CelulaName
        {
            get { return _celulaName; }
            set { SetProperty(ref _celulaName, value); }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetProperty(ref _Date, value); }
        }

        private TimeSpan _celulaStartTime;
        public TimeSpan CelulaStartTime
        {
            get { return _celulaStartTime; }
            set { SetProperty(ref _celulaStartTime, value); }
        }

        private float _offer;
        public float Offer
        {
            get { return _offer; }
            set { SetProperty(ref _offer, value); }
        }

        private List<Person> _Participants;
        public List<Person> Participants
        {
            get { return _Participants; }
            set { SetProperty(ref _Participants, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand SaveButtonCommand { get; }
        public DelegateCommand SentReportCommand { get; }
        #endregion

        public AddEditReportPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SaveButtonCommand = new DelegateCommand(SaveButtonAction);
            SentReportCommand = new DelegateCommand(SentReportAction);

            PageTitle = "Relatório";
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            ClearFields();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            report = (Report)parameters["report"];

            if (report != null)
            {
                PageTitle = "Editar";

                CelulaName = report.CelulaName;
                Date = DateTime.Now.Date;
                CelulaStartTime = report.CelulaStartTime;
                Offer = report.Offer;

                foreach (Person participant in report.Participants)
                {
                    Participants.Add(participant);
                }
            }
            else
            {
                PageTitle = "Relatório";
            }
        }

        #region Action
        private void SaveButtonAction()
        {

        }

        private void SentReportAction()
        {

        }
        #endregion

        #region Methods
        private void ClearFields()
        {
            PageTitle = string.Empty;

            //Name = string.Empty;
            //Email = string.Empty;
            //Phone = string.Empty;
            //Birthday = DateTime.MinValue;
        }
        #endregion
    }
}
