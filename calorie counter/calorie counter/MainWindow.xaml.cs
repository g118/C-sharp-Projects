using System.Windows;
using System.Windows.Input;

namespace calorie_counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalcalorie = 0;
        public MainWindow()
        {
            
            InitializeComponent();
            lbl_result.Content = totalcalorie;
            

        }

        private void img_apple_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int val_apple = 80;
            totalcalorie = val_apple + totalcalorie;
            lbl_result.Content = totalcalorie;
        }

        private void img_banana_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int val_banana = 115;
            totalcalorie = val_banana + totalcalorie;
            lbl_result.Content = totalcalorie;
        }

        private void img_Orange_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int val_orange = 90;
            totalcalorie = val_orange + totalcalorie;
            lbl_result.Content = totalcalorie;
        }

        private void img_Pear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int val_pear = 120;
            totalcalorie = val_pear + totalcalorie;
            lbl_result.Content = totalcalorie;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            totalcalorie = 0;
            lbl_result.Content = 0;

        }

       
    }
}
