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

            var celula1 = new Celula() { Name = "Celula 1", LeaderName = "Fulano 1", AnfitriaoName = "Ciclano 1" };
            var celula2 = new Celula() { Name = "Celula 2", LeaderName = "Fulano 2", AnfitriaoName = "Ciclano 2" };
            var celula3 = new Celula() { Name = "Celula 3", LeaderName = "Fulano 3", AnfitriaoName = "Ciclano 3" };
            var celula4 = new Celula() { Name = "Celula 4", LeaderName = "Fulano 4", AnfitriaoName = "Ciclano 4" };

            celulasList.Add(celula1);
            celulasList.Add(celula2);
            celulasList.Add(celula3);
            celulasList.Add(celula4);
            
            return celulasList;
        }
    }
}
