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
        private ObservableCollection<Cell> _cellsList;
        public ObservableCollection<Cell> _CellsList
        {
            get { return _cellsList; }
            set { SetProperty(ref _cellsList, value); }
        }

        public CellsPageViewModel()
        {

        }
	}
}
