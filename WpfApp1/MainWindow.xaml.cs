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

namespace WpfApp1
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

        private void Clicked(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;  
            Random random = new Random();
            Brush random_color = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0,255)));

            button.Background = random_color;
            MessageBox.Show($"I am {button.Content}");
        }

        private void RightClicked(object sender,RoutedEventArgs e)
        {
            var button=sender as Button;

            foreach (var item in BigStackPanel.Children)
            {
                if(item is StackPanel sP)
                {
                    foreach (var item2 in sP.Children)
                    {
                        if (item2 == button)
                        {

                            this.Title = button.Content.ToString().Split(' ')[1];
                            sP.Children.Remove(button);
                            break;
                        }
                    }
                }
            }
        }

    }
}
