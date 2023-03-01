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

namespace HomeTask1_WPF
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonRandomColor (object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            SolidColorBrush brush = new SolidColorBrush(
            Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
            (sender as Button).Background = brush;
            t1.Text = $"The color code of the button you clicked -> {brush.ToString()}";
            t2.Background = brush;

            // Message  Box
            MessageBox.Show($"Hello , Button's color code -> {brush}");
        }

        private void ButtonDelete(object sender,RoutedEventArgs e)
        {
            var parent = VisualTreeHelper.GetParent(sender as Button) as Panel;
            parent.Children.Remove(sender as Button);
        }
        

        //Sola Basildiqda olunalar

        private void Button_Click1_Left(object sender, RoutedEventArgs e)  { ButtonRandomColor(sender, e); }

        private void Button_Click2_Left(object sender, RoutedEventArgs e) { ButtonRandomColor(sender, e); }

        private void Button_Click3_Left(object sender, RoutedEventArgs e) { ButtonRandomColor(sender, e); }

        private void Button_Click4_Left(object sender, RoutedEventArgs e) { ButtonRandomColor(sender, e); }
        
        private void Button_Click5_Left(object sender, RoutedEventArgs e) { ButtonRandomColor(sender, e); }
        
        private void Button_Click6_Left(object sender, RoutedEventArgs e) { ButtonRandomColor(sender, e); }

        // Sag Duymeni Basdiqda

        private void Button_Click1_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 1"; }

        private void Button_Click2_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 12"; }

        private void Button_Click3_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 13"; }

        private void Button_Click4_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 14"; }

        private void Button_Click5_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 15"; }

        private void Button_Click6_Right(object sender, MouseButtonEventArgs e)  { ButtonDelete(sender, e); this.Title = "Silindi -> 16"; }



    }

}
