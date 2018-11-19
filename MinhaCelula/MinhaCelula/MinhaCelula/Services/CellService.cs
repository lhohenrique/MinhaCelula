using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class CellService
    {
        private static ObservableCollection<Cell> cellsList { get; set; } 

        public static ObservableCollection<Cell> GetCells()
        {
            cellsList = new ObservableCollection<Cell>();

            var cell1 = new Cell() { Name = "Cell 1", Address = "Rua 1", CellStartTime = TimeSpan.FromHours(11) };
            var cell2 = new Cell() { Name = "Cell 2", Address = "Rua 2", CellStartTime = TimeSpan.FromHours(12) };
            var cell3 = new Cell() { Name = "Cell 3", Address = "Rua 3", CellStartTime = TimeSpan.FromHours(13) };
            var cell4 = new Cell() { Name = "Cell 4", Address = "Rua 4", CellStartTime = TimeSpan.FromHours(14) };

            cellsList.Add(cell1);
            cellsList.Add(cell2);
            cellsList.Add(cell3);
            cellsList.Add(cell4);
            
            return cellsList;
        }
    }
}
