using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaCelula.Models
{
    public class Church : BindableBase
    {
        #region Properties
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private string _PastorName;
        public string PastorName
        {
            get { return _PastorName; }
            set { SetProperty(ref _PastorName, value); }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { SetProperty(ref _Phone, value); }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
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

        private List<Person> _Leaders;
        public List<Person> Leaders
        {
            get { return _Leaders; }
            set { SetProperty(ref _Leaders, value); }
        }

        private int _LeadersNumber;
        public int LeadersNumber
        {
            get { return Leaders != null ? Leaders.Count : 0; }
        }

        private List<Cell> _Cells;
        public List<Cell> Cells
        {
            get { return _Cells; }
            set { SetProperty(ref _Cells, value); }
        }

        private int _CellsNumber;
        public int CellsNumber
        {
            get { return Cells != null ? Cells.Count : 0; }
        }
        #endregion
    }
}
