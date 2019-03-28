using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class ReportService
    {
        private static ObservableCollection<Report> reportList { get; set; } 

        public static ObservableCollection<Report> GetReports()
        {
            reportList = new ObservableCollection<Report>();

            var report1 = new Report() { CelulaName="Leão da Tribo de Juda", Date = DateTime.Now.Date, Sent = true, CelulaStartTime = TimeSpan.FromHours(11) };
            var report2 = new Report() { CelulaName = "Chamados para fora", Date = DateTime.Now.Date, Sent = true, CelulaStartTime = TimeSpan.FromHours(12) };
            var report3 = new Report() { CelulaName = "Videira", Date = DateTime.Now.Date, Sent = true, CelulaStartTime = TimeSpan.FromHours(13) };
            var report4 = new Report() { CelulaName = "Celula 1", Date = DateTime.Now.Date, Sent = false, CelulaStartTime = TimeSpan.FromHours(14) };

            reportList.Add(report1);
            reportList.Add(report2);
            reportList.Add(report3);
            reportList.Add(report4);

            return reportList;
        }
    }
}
