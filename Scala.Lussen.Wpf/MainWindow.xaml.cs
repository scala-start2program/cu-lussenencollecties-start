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
using System.IO;

namespace Scala.Lussen.Wpf
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
        Random rnd = new Random();

        private void btnWhile1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnWhile2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnWhile3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor6_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFor7_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnArray1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnArray2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnArray3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnArray4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnList1_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnList2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnList3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnForEach1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnForEach2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnForEach3_Click(object sender, RoutedEventArgs e)
        {
        }
        private Color IdealTextColor(Color bg)
        {
            int nThreshold = 105;
            int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) + (bg.B * 0.114));

            Color foreColor = (255 - bgDelta < nThreshold) ? Color.FromRgb(0, 0, 0) : Color.FromRgb(255, 255, 255);
            return foreColor;
        }

        private void btnForEach4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnDo1_Click(object sender, RoutedEventArgs e)
        {
        }


        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
