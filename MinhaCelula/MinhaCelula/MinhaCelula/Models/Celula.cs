using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaCelula.Models
{
    public class Celula : BindableBase
    {
        #region Properties
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private int _LeaderId;
        public int LeaderId
        {
            get { return _LeaderId; }
            set { SetProperty(ref _LeaderId, value); }
        }

        private string _leaderName;
        public string LeaderName
        {
            get { return _leaderName; }
            set { SetProperty(ref _leaderName, value); }
        }
        
        private int _anfitriaoId;
        public int AnfitriaoId
        {
            get { return _anfitriaoId; }
            set { SetProperty(ref _anfitriaoId, value); }
        }

        private string _anfitriaoName;
        public string AnfitriaoName
        {
            get { return _anfitriaoName; }
            set { SetProperty(ref _anfitriaoName, value); }
        }

        private int _ChurchId;
        public int ChurchId
        {
            get { return _ChurchId; }
            set { SetProperty(ref _ChurchId, value); }
        }

        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { SetProperty(ref _Country, value); }
        }

        private string _State;
        public string State
        {
            get { return _State; }
            set { SetProperty(ref _State, value); }
        }

        private string _City;
        public string City
        {
            get { return _City; }
            set { SetProperty(ref _City, value); }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { SetProperty(ref _Address, value); }
        }

        private List<Person> _Members;
        public List<Person> Members
        {
            get { return _Members; }
            set { SetProperty(ref _Members, value); }
        }

        public int MemberNumber
        {
            get { return Members != null ? Members.Count : 0; }
        }

        private string _meetingDate;
        public string MeetingDate
        {
            get { return _meetingDate; }
            set { SetProperty(ref _meetingDate, value); }
        }

        public string NextMeetingDate
        {
            get { return "15/05/2019"; }
        }

        private TimeSpan _celulaStartTime;
        public TimeSpan CelulaStartTime
        {
            get { return _celulaStartTime; }
            set { SetProperty(ref _celulaStartTime, value); }
        }

        public string StartTimeFormated
        {
            get { return CelulaStartTime.ToString(@"hh\:mm") + " horas"; }
        }
        #endregion
    }
}
