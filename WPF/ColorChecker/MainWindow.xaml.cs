using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Collections.ObjectModel;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        ObservableCollection<MyColor> myColors = new ObservableCollection<MyColor> ();

        public MainWindow() {
            InitializeComponent ();
            DataContext = GetColorList ();
            setColor ();
        }

        private void setColor() {
            colorArea.Background = new SolidColorBrush ( Color.FromRgb ( byte.Parse ( rValue.Text ), byte.Parse ( gValue.Text ), byte.Parse ( bValue.Text ) ) );
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor ();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            MyColor mc = new MyColor () {Color = Color.FromRgb ( byte.Parse ( rValue.Text ), byte.Parse ( gValue.Text ), byte.Parse ( bValue.Text ) )};
            stockList.Items.Add ( mc );
        }


        private MyColor[] GetColorList() {
            return typeof ( Colors ).GetProperties ( BindingFlags.Public | BindingFlags.Static )
                .Select ( i => new MyColor () { Color = (Color)i.GetValue ( null ), Name = i.Name } ).ToArray ();
        }


        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            var selectedColor = (MyColor)( (ComboBox)sender ).SelectedItem;
            rValue.Text = selectedColor.Color.R.ToString ();
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return "Red:" + Color.R + " Green:" + Color.G + "Blue:" + Color.B;
        }
    }
}
