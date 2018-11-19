using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaCelula.Models
{
    public class Cell : BindableBase
    {
        #region Properties
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
        
        private int _HostId;
        public int HostId
        {
            get { return _HostId; }
            set { SetProperty(ref _HostId, value); }
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

        private int _MemberNumber;
        public int MemberNumber
        {
            get { return Members != null ? Members.Count : 0; }
        }

        private TimeSpan _CellStartTime;
        public TimeSpan CellStartTime
        {
            get { return _CellStartTime; }
            set { SetProperty(ref _CellStartTime, value); }
        }
        #endregion
    }
}
