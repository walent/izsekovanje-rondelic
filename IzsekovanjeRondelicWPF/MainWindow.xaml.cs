using CircleInRectangleLib;
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

namespace IzsekovanjeRondelicWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CircleInRectangle circle = new CircleInRectangle();
        double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            //double wi = double.Parse(width.Text);
            //double le = double.Parse(lenght.Text);
            //double ra = double.Parse(radious.Text);
            //double sp = double.Parse(space.Text);
            result = circle.numberOfSlugs(257, 157, 1.7, 1);        
            numberOfSlugs.Content = result;
            Console.WriteLine(result);

        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            width.Text = "";
            lenght.Text = "";
            radious.Text = "";
            space.Text = "";

        }
    }
}
