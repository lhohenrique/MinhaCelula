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

            var celulas = new MenuItem() { Title = "Células", Icon = "", TargetType = typeof(CellsPage) };
            var reports = new MenuItem() { Title = "Relatórios", Icon = "", TargetType = typeof(ReportsPage) };
            var persons = new MenuItem() { Title = "Pessoas", Icon = "", TargetType = typeof(PersonsPage) };
            var schedule = new MenuItem() { Title = "Agenda", Icon = "", TargetType = typeof(PersonsPage) };
            var churchs = new MenuItem() { Title = "Igrejas", Icon = "", TargetType = typeof(ChurchsPage) };

            menuList.Add(celulas);
            menuList.Add(reports);
            menuList.Add(persons);
            menuList.Add(schedule);
            menuList.Add(churchs);

            return menuList;
        }
    }
}
