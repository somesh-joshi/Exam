using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hall
    {
        private string _name;
        private string _contactNumber;
        private double _costPerDay;
        private string _ownerName;
        private DateTime _bookingDate;

        public Hall(string _name, string _contactNumber, double _costPerDay, string _ownerName, DateTime _bookingDate)
        {
            this._name = _name;
            this._contactNumber = _contactNumber;
            this._costPerDay = _costPerDay;
            this._ownerName = _ownerName;
            this._bookingDate = _bookingDate;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return this._contactNumber;
            }
            set
            {
                this._contactNumber = value;
            }
        }
        public double CostPerDay
        {
            get
            {
                return this._costPerDay;
            }
            set
            {
                this._costPerDay = value;
            }
        }
        public string OwnerName
        {
            get
            {
                return this._ownerName;
            }
            set
            {
                this._ownerName = value;
            }
        }
        public DateTime BookingDate
        {
            get
            {
                return this._bookingDate;
            }
            set
            {
                this._bookingDate = value;
            }
        }

    }