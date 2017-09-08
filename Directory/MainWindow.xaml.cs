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
            EnableDisableButton();            
        }

        private void EnableDisableButton() {
            if (treeView.SelectedItem == null) {
                btn_AddFolder.IsEnabled = false;
                btn_AddFile.IsEnabled = false;
            }
            treeView.GotFocus += TreeView_GotFocus;
            treeView.LostFocus += TreeView_LostFocus;
        }

        private void TreeView_LostFocus(object sender, RoutedEventArgs e) {
            btn_AddFolder.IsEnabled = false;
            btn_AddFile.IsEnabled = false;
        }

        private void TreeView_GotFocus(object sender, RoutedEventArgs e) {
            btn_AddFolder.IsEnabled = true;
            btn_AddFile.IsEnabled = true;
        }

        private void btn_AddFolder_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_AddFile_Click(object sender, RoutedEventArgs e) {

        }
    }
}
