using MinhaCelula.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinhaCelula.ViewModels
{
	public class AddReportViewModel : BindableBase
	{
        #region Properties
        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetProperty(ref _Date, value); }
        }

        private TimeSpan _CellStartTime;
        public TimeSpan CellStartTime
        {
            get { return _CellStartTime; }
            set { SetProperty(ref _CellStartTime, value); }
        }

        private float _offer;
        public float Offer
        {
            get { return _offer; }
            set { SetProperty(ref _offer, value); }
        }

        private List<Person> _Participants;
        public List<Person> Participants
        {
            get { return _Participants; }
            set { SetProperty(ref _Participants, value); }
        }
        #endregion

        public AddReportViewModel()
        {

        }
	}
}
