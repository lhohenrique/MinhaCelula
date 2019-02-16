using MinhaCelula.Commons;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaCelula.Models
{
    public class Person : BindableBase
    {
        #region Properties
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { SetProperty(ref _Phone, value); }
        }

        private DateTime _Birthday;
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { SetProperty(ref _Birthday, value); }
        }

        private PersonProfile _Profile;
        public PersonProfile Profile
        {
            get { return _Profile; }
            set { SetProperty(ref _Profile, value); }
        }

        public string ProfileTitle
        {
            get { return _Profile.ToString(); }
        }

        public bool IsAdmin
        {
            get { return _Profile == PersonProfile.Admin; }
        }

        public bool IsPastor
        {
            get { return _Profile == PersonProfile.Pastor;  }
        }

        public bool IsCoordinator
        {
            get { return _Profile == PersonProfile.Coordinator; }
        }

        public bool IsLeader
        {
            get { return _Profile == PersonProfile.Leader; }
        }

        public bool IsMember
        {
            get { return _Profile == PersonProfile.Member; }
        }

        public bool IsVisitant
        {
            get { return _Profile == PersonProfile.Visitant; }
        }

        private int _celulaId;
        public int CelulaId
        {
            get { return _celulaId; }
            set { SetProperty(ref _celulaId, value); }
        }
        #endregion
    }
}
