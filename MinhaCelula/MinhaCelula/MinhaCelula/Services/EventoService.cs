using MinhaCelula.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class EventoService : BindableBase
    {
        private static ObservableCollection<Evento> eventoList { get; set; }

        public static ObservableCollection<Evento> GetEventos()
        {
            eventoList = new ObservableCollection<Evento>();

            var evento1 = new Evento()
            {
                Title = "Batismo",
                Date = DateTime.Now.Date,
                StartTime = TimeSpan.FromHours(11),
                Location = "Igreja Local"
            };
            var evento2 = new Evento()
            {
                Title = "Reunião de líderes",
                Date = DateTime.Now.Date,
                StartTime = TimeSpan.FromHours(9),
                Location = "Igreja Local"
            };
            
            eventoList.Add(evento1);
            eventoList.Add(evento2);

            return eventoList;
        }
    }
}
