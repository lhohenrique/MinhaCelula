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

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _leaderId;
        public int LeaderId
        {
            get { return _leaderId; }
            set { SetProperty(ref _leaderId, value); }
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

        private int _churchId;
        public int ChurchId
        {
            get { return _churchId; }
            set { SetProperty(ref _churchId, value); }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        private List<Person> _members;
        public List<Person> Members
        {
            get { return _members; }
            set { SetProperty(ref _members, value); }
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
