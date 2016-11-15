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

namespace BMI_Index
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, RoutedEventArgs e)
        {
            const int a = 703;
            const double limit1 = 18.5;
            const int limit2 = 25;
            int result;

            int weight;
            try
            {
                weight = int.Parse(tb2.Text);
            }
            catch
            { weight = 0; }
            int height;
            try
            {
                height = int.Parse(tb1.Text);
            }
            catch
            { height = 0; }
            Int32 tt;
                tt = height * height;
            result = weight * a / tt;
            string resultToShow = result.ToString();
            if (result > limit1 && result < limit2)



                MessageBox.Show(" Your Bmi is" +" " +  result  +  ","  + "so your weight is optimal");
            else if (result < limit1)
                MessageBox.Show(" Your Bmi is" +" " + result +  ","  + "so you are underweight");
            else if (result > limit2)
                MessageBox.Show(" Your Bmi is" +" " + result +  ","  + "so you are overweight");

        }
    }
}
