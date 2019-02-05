using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class CelulaService
    {
        private static ObservableCollection<Celula> celulasList { get; set; } 

        public static Celula GetCelulaFromLoggedUser()
        {
            return new Celula()
            {
                Name = "Celula 1",
                MeetingDate = "Quarta-feira",
                CelulaStartTime = TimeSpan.FromHours(19)
            };
        }

        public static ObservableCollection<Celula> GetCelulas()
        {
            celulasList = new ObservableCollection<Celula>();

            var celula1 = new Celula() { Name = "Celula 1", Address = "Rua 1", CelulaStartTime = TimeSpan.FromHours(11) };
            var celula2 = new Celula() { Name = "Celula 2", Address = "Rua 2", CelulaStartTime = TimeSpan.FromHours(12) };
            var celula3 = new Celula() { Name = "Celula 3", Address = "Rua 3", CelulaStartTime = TimeSpan.FromHours(13) };
            var celula4 = new Celula() { Name = "Celula 4", Address = "Rua 4", CelulaStartTime = TimeSpan.FromHours(14) };

            celulasList.Add(celula1);
            celulasList.Add(celula2);
            celulasList.Add(celula3);
            celulasList.Add(celula4);
            
            return celulasList;
        }
    }
}
