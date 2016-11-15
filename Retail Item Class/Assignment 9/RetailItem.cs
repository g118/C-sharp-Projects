using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment_9
{
    class RetailItem : INotifyPropertyChanged
    {
        public List<string> Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }
        private List<string> _description;
        public List<string> Unit
        {
            get { return _unit; }
            set { _unit = value; OnPropertyChanged(); }
        }
        private List<string> _unit;
        public List<string> Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }
        private List<string> _price;
        public RetailItem() //constructor
        {
            string[] description = new string[] { "Jacket", "Jeans", "Shirts" };
            int[] unit = new int[] { 12, 40, 20 };
            decimal[] price = new decimal[] { 59.95m, 34.95m, 24.95m };

            _description = new List<string>();
            for (int i=0; i<description.Length; i++)
            {
               _description.Add(description[i].ToString());
            }

            _unit = new List<string>();
            for (int i=0; i<unit.Length; i++)
            {
                _unit.Add(unit[i].ToString());
            }

            _price = new List<string>();
            for (int i=0; i<price.Length; i++)
            {
                _price.Add(price[i].ToString("c2"));
            }


        }
        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion

    }
}
