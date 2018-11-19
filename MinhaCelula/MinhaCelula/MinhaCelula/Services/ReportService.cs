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

            var report1 = new Report() { Date = DateTime.Now.Date, Sent = true, CellStartTime = TimeSpan.FromHours(11) };
            var report2 = new Report() { Date = DateTime.Now.Date, Sent = true, CellStartTime = TimeSpan.FromHours(12) };
            var report3 = new Report() { Date = DateTime.Now.Date, Sent = true, CellStartTime = TimeSpan.FromHours(13) };
            var report4 = new Report() { Date = DateTime.Now.Date, Sent = false, CellStartTime = TimeSpan.FromHours(14) };

            reportList.Add(report1);
            reportList.Add(report2);
            reportList.Add(report3);
            reportList.Add(report4);

            return reportList;
        }
    }
}
