using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaCelula.Models
{
    public class Report : BindableBase
    {
        #region Properties
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }

        private int _celulaId;
        public int CelulaId
        {
            get { return _celulaId; }
            set { SetProperty(ref _celulaId, value); }
        }

        private int _LeaderId;
        public int LeaderId
        {
            get { return _LeaderId; }
            set { SetProperty(ref _LeaderId, value); }
        }

        // Anfitrião
        private int _HostId;
        public int HostId
        {
            get { return _HostId; }
            set { SetProperty(ref _HostId, value); }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetProperty(ref _Date, value); }
        }

        private TimeSpan _celulaStartTime;
        public TimeSpan CelulaStartTime
        {
            get { return _celulaStartTime; }
            set { SetProperty(ref _celulaStartTime, value); }
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

        private int _ParticipantsNumber;
        public int ParticipantsNumber
        {
            get { return Participants != null ? Participants.Count : 0; }
        }

        private List<Person> _Visitors;
        public List<Person> Visitors
        {
            get { return _Visitors; }
            set { SetProperty(ref _Visitors, value); }
        }

        private int _VisitorsNumber;
        public int VisitorsNumber
        {
            get { return Visitors != null ? Visitors.Count : 0; }
        }

        private List<Person> _Converted;
        public List<Person> Converted
        {
            get { return _Converted; }
            set { SetProperty(ref _Converted, value); }
        }

        private int _ConversionsNumber;
        public int ConversionsNumber
        {
            get { return Converted != null ? Converted.Count : 0; }
        }

        private bool _Sent;
        public bool Sent
        {
            get { return _Sent; }
            set { SetProperty(ref _Sent, value); }
        }
        #endregion
    }
}
