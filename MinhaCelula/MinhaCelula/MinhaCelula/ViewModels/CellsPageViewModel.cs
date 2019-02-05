using MinhaCelula.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class CellsPageViewModel : BindableBase
	{
        private ObservableCollection<Celula> _celulasList;
        public ObservableCollection<Celula> _CelulasList
        {
            get { return _celulasList; }
            set { SetProperty(ref _celulasList, value); }
        }

        public CellsPageViewModel()
        {

        }
	}
}
