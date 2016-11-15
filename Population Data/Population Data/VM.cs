using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Population_Data
{
    class VM : INotifyPropertyChanged
    {
        public int Average
        {
            get { return _average; }
            set { _average = value; OnPropertyChanged(); }
        }
        private int _average;

        public string GreatestYear
        {
            get { return _greatestYear; }
            set { _greatestYear = value; OnPropertyChanged(); }
        }
        private string _greatestYear;

        public string LeastYear
        {
            get { return _leastYear; }
            set { _leastYear = value;  OnPropertyChanged(); }
        }
        private string _leastYear;

        private int _currentLine;
        private int _lastLine = 0;
        private int _total = 0;
        private int _count = 0;
        private int _increase = 0;
        private int _least = 0;
        private int _greatest = 0;

        public VM()
        {
            const string POP_DATA = "USPopulation.txt";
            List<string> lines = File.ReadLines(POP_DATA).ToList();

            
            foreach (string dataLine in lines)
            {
                _currentLine = Convert.ToInt32(dataLine);

                if (_lastLine > 0)
                {
                    _increase = _currentLine - _lastLine;
                    
                    if (_increase > _greatest)
                    {
                        _greatest = _increase;
                        _greatestYear = (1950 + _count).ToString();
                    }
                    if (_least == 0)
                    {
                        _least = _increase;
                        _leastYear = (1950 + _count).ToString();
                    }
                    else if (_increase < _least)
                    {
                        _least = _increase;
                        _leastYear = (1950 + _count).ToString();
                    }
                    _total = _total + _increase;
                }

                _lastLine = _currentLine;
                _count++;
            }
            _average = _total /( _count-1);

        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
