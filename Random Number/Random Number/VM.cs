using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Random_Number
{
    class VM : INotifyPropertyChanged
    {
        /*nullable int so default textbox isn't 0*/
        int? _guess;
        int _number;
        string _lastGuess;
        string _allGuesses;

        public int? Guess
        {
            get { return _guess; }
            set { _guess = value;  NotifyPropertyChanged(); }
        }

        public string lastGuess
        {
            get { return _lastGuess; }
            set { _lastGuess = value; NotifyPropertyChanged(); }
        }

        public string allGuesses
        {
            get { return _allGuesses; }
            set { _allGuesses = value; NotifyPropertyChanged(); }
        }

        /*check guess and give user hint*/
        public void Check()
        {
            lastGuess = _guess.ToString();
            allGuesses = _allGuesses + _lastGuess + ", ";
            if (_guess >=1 & _guess < _number)
            {
                MessageBox.Show("Too low, try again");
            }
            else if (_guess > _number & _guess <=100)
            {
                MessageBox.Show("Too high, try again");
            }
            else if (_guess == _number)
            {
                MessageBox.Show("Congratulations! You guessed correctly.");
                /*generate a new random number*/
                Number();
                /*reset all textboxes - ideally, this should reset before user guesses the next random number so it is clear that they can play again*/
                _lastGuess = "";
                _allGuesses = "";
            }
            else
            {
                MessageBox.Show("Invalid guess, please try again.");
            }
        }

        /*generate random number*/
        public void Number()
        {
            Random r = new Random();
            _number = r.Next(1, 100);
            /* uncomment next line of code to test with value 25 */
            //_number = 25; /

        }
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
  }
}
