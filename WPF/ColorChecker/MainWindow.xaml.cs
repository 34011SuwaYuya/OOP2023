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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Dictionary<int, (int, int, int)> keyValuePairs = new Dictionary<int, (int, int, int)> ();

        public MainWindow() {
            InitializeComponent ();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            colorArea.Background = new SolidColorBrush ( Color.FromRgb ( byte.Parse ( rValue.Text ), byte.Parse ( gValue.Text ), byte.Parse ( bValue.Text ) ) );
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

        }

        
    }
    //public class ColorValue(){
    //        public int value;

    //    }
}
