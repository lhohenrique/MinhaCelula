using MinhaCelula.Models;
using MinhaCelula.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace MinhaCelula.ViewModels
{
	public class CelulasPageViewModel : BindableBase, INavigatedAware
	{
        private INavigationService navigationService;

        #region Properties
        private ObservableCollection<Celula> _celulasList;
        public ObservableCollection<Celula> CelulasList
        {
            get { return _celulasList; }
            set { SetProperty(ref _celulasList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddCelulaButtonCommand { get; set; }
        public DelegateCommand<Celula> SelectCelulaButtonCommand { get; set; }
        #endregion

        public CelulasPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddCelulaButtonCommand = new DelegateCommand(AddCelulaButtonAction);
            SelectCelulaButtonCommand = new DelegateCommand<Celula>(SelectCelulaButtonAction);

            CelulasList = CelulaService.GetCelulas();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        #region Actions
        private void AddCelulaButtonAction()
        {
            navigationService.NavigateAsync("AddEditCelulaPage");
        }

        private void SelectCelulaButtonAction(Celula celulaSelected)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("celula", celulaSelected);

            navigationService.NavigateAsync("AddEditCelulaPage", navigationParams);
        }
        #endregion
    }
}
