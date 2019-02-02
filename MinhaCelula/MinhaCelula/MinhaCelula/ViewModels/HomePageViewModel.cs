using MinhaCelula.Models;
using MinhaCelula.Services;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

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

        private ObservableCollection<Evento> _eventosList;
        public ObservableCollection<Evento> EventosList
        {
            get { return _eventosList; }
            set { SetProperty(ref _eventosList, value); }
        }
        #endregion

        #region Commands
        #endregion

        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            CellName = "MinhaCelula 1";
            NextMeeting = "15/05/2019";
            CellStartTime = "19 horas";

            EventosList = EventoService.GetEventos();
        }

        #region Actions
        #endregion

        #region Events
        #endregion

        #region Private Methods
        #endregion

        #region Public Methods
        #endregion
    }
}
