using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Directory {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            level1.Foreground = Brushes.Red;
            level2.Foreground = Brushes.Green;
        }

        private void btnLevel1_Click(object sender, RoutedEventArgs e) {
            level1.Foreground = Brushes.White;
        }

        private void btnLevel2_Click(object sender, RoutedEventArgs e) {
            level2.Foreground = Brushes.Yellow;


        }
    }
}
