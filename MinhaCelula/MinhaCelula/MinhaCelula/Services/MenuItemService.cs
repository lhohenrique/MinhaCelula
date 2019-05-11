using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class MenuItemService
    {
        private static ObservableCollection<MenuItem> menuList { get; set; } 

        public static ObservableCollection<MenuItem> GetMenuItems()
        {
            menuList = new ObservableCollection<MenuItem>();

            var churchs = new MenuItem() { Title = "Igrejas", Icon = "", TargetType = typeof(ChurchsPage) };
            var celulas = new MenuItem() { Title = "Células", Icon = "", TargetType = typeof(CelulasPage) };
            var reports = new MenuItem() { Title = "Relatórios", Icon = "", TargetType = typeof(ReportsPage) };
            var pastores = new MenuItem() { Title = "Pastores", Icon = "", TargetType = typeof(PersonsPage) };
            var coordenadores = new MenuItem() { Title = "Coordenadores", Icon = "", TargetType = typeof(PersonsPage) };
            var lideres = new MenuItem() { Title = "Líderes", Icon = "", TargetType = typeof(PersonsPage) };
            var membros = new MenuItem() { Title = "Membros", Icon = "", TargetType = typeof(PersonsPage) };
            var schedule = new MenuItem() { Title = "Agenda", Icon = "", TargetType = typeof(PersonsPage) };

            Person loggedUser = PersonService.GetLoggedUser();

            if (loggedUser.IsAdmin)
            {
                menuList.Add(churchs);
                menuList.Add(celulas);
                menuList.Add(reports);
                menuList.Add(pastores);
                menuList.Add(coordenadores);
                menuList.Add(lideres);
                menuList.Add(membros);
                menuList.Add(schedule);
            }
            else if (loggedUser.IsPastor)
            {
                menuList.Add(celulas);
                menuList.Add(reports);
                menuList.Add(coordenadores);
                menuList.Add(lideres);
                menuList.Add(membros);
                menuList.Add(schedule);
            }
            else if (loggedUser.IsCoordinator)
            {
                menuList.Add(celulas);
                menuList.Add(reports);
                menuList.Add(lideres);
                menuList.Add(membros);
                menuList.Add(schedule);
            }
            else if (loggedUser.IsLeader)
            {
                menuList.Add(celulas);
                menuList.Add(reports);
                menuList.Add(membros);
                menuList.Add(schedule);
            }
            
            return menuList;
        }
    }
}
