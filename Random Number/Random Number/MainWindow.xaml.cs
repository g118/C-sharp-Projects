using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/*  Group 5
    Attila
    Chris
    Gurpreet
    Tanvir
    Muthu Kumar
    Eliza
    Bhavani */

namespace Random_Number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
    
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
            vm.Number();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            vm.Check();
            /*tbLast.Text = tbGuess.Text;
            allGuesses= allGuesses + tbGuess.Text + ", ";
            tbAll.Text = allGuesses;*/

        }
    }
}
