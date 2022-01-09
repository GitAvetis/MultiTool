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


namespace testovoeAvetisyan1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void BaseWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {


            button.Height = 50 * BaseWindow.ActualHeight / 800;

            button.Width = 80 * BaseWindow.ActualWidth / 800;

            button.FontSize = 20 * BaseWindow.ActualHeight / 800;
            double size = border.ActualHeight;

            //label.Height = 50 * BaseWindow.ActualHeight / 800;

            //label.Width = 150 * BaseWindow.ActualWidth / 800;

            //textBox.Margin = new Thickness(15 + label.Width, 20, 30, 40);

            //label.FontSize = 20 * BaseWindow.ActualHeight / 800;


            //textBox.Height = 50 *( BaseWindow.ActualHeight / 800);

            //textBox.Width =BaseWindow.ActualWidth-( button.Width+label.ActualWidth)-100*(BaseWindow.ActualWidth / 800);

            //textBox.FontSize = 20 * BaseWindow.ActualHeight / 800;
        }

    }
}
