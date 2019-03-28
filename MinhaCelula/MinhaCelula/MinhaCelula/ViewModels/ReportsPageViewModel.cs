using MinhaCelula.Models;
using MinhaCelula.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class ReportsPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Report> _reportsList;
        public ObservableCollection<Report> ReportsList
        {
            get { return _reportsList; }
            set { SetProperty(ref _reportsList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddReportButtonCommand { get; set; }
        public DelegateCommand<Report> SelectReportButtonCommand { get; set; }
        #endregion

        public ReportsPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddReportButtonCommand = new DelegateCommand(AddReportButtonAction);
            SelectReportButtonCommand = new DelegateCommand<Report>(SelectReportButtonAction);

            ReportsList = ReportService.GetReports();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddReportButtonAction()
        {
            navigationService.NavigateAsync("AddEditReportPage");
        }

        private void SelectReportButtonAction(Report reportSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("report", reportSelected);

            navigationService.NavigateAsync("AddEditReportPage", navigationParams);
        }
        #endregion
    }
}
