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
        private Celula _celula;
        public Celula Celula
        {
            get { return _celula; }
            set { SetProperty(ref _celula, value); }
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
            Celula = CelulaService.GetCelulaFromLoggedUser();

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
