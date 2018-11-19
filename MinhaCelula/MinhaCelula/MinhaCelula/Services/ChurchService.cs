using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class ChurchService
    {
        private static ObservableCollection<Church> churchList { get; set; } 

        public static ObservableCollection<Church> GetChurchs()
        {
            churchList = new ObservableCollection<Church>();

            var church1 = new Church() { Name = "Church 1", PastorName = "Pr. 1", Phone = "123456" };
            var church2 = new Church() { Name = "Church 2", PastorName = "Pr. 2", Phone = "123456" };
            var church3 = new Church() { Name = "Church 3", PastorName = "Pr. 3", Phone = "123456" };
            var church4 = new Church() { Name = "Church 4", PastorName = "Pr. 4", Phone = "123456" };

            churchList.Add(church1);
            churchList.Add(church2);
            churchList.Add(church3);
            churchList.Add(church4);

            return churchList;
        }
    }
}
