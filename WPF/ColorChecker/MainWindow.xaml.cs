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
        public bool cbKeep;

        MyColor[] allColor;

        public MainWindow() {
            cbKeep = false;
            InitializeComponent ();
            DataContext = GetColorList ();
            allColor = GetColorList ();
            setColor ();
        }

        private void setColor() {
            colorArea.Background = new SolidColorBrush ( Color.FromRgb ( byte.Parse ( rValue.Text ), byte.Parse ( gValue.Text ), byte.Parse ( bValue.Text ) ) );
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            if (!cbKeep) {
                colorCB.SelectedIndex = -1;
            }

            setColor ();
        }


        private void stockButton_Click(object sender, RoutedEventArgs e) {

            MyColor mc = new MyColor () {Color = Color.FromRgb ( byte.Parse ( rValue.Text ), byte.Parse ( gValue.Text ), byte.Parse ( bValue.Text ) ), Name = colorCB.Text };

            string mcName = getColorName ( mc );
            if (mcName != "None") {
                mc.Name = mcName;
            }
            else {
                mc.Name = "R:" + mc.Color.R + " G:" + mc.Color.G + " B:" + mc.Color.B;
            }
            stockList.Items.Add ( mc );
        }




        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            
            if (colorCB.SelectedIndex == -1) {
                return;
            }

            cbKeep = true;
            var selectedColor = (MyColor)( (ComboBox)sender ).SelectedItem;
            rValue.Text = selectedColor.Color.R.ToString ();
            gValue.Text = selectedColor.Color.G.ToString ();
            bValue.Text = selectedColor.Color.B.ToString ();

            setColor ();
            cbKeep = false;
        }

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            MyColor myColor = (MyColor)stockList.SelectedItem;

            rValue.Text = myColor.Color.R.ToString();
            gValue.Text = myColor.Color.G.ToString ();
            bValue.Text = myColor.Color.B.ToString ();
            setColor ();
            colorCB.SelectedIndex = -1;
        }

        public string getColorName(MyColor presentColor) {
            MyColor targetColor = allColor.FirstOrDefault ( c => c.Equals ( presentColor ) );
            if (targetColor == null) {
                return "None";
            }
            else {
                return targetColor.Name;
            }
        }

        private MyColor[] GetColorList() {
            return typeof ( Colors ).GetProperties ( BindingFlags.Public | BindingFlags.Static )
                .Select ( i => new MyColor () { Color = (Color)i.GetValue ( null ), Name = i.Name } ).ToArray ();
        }

    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return Name;            
        }

        public override bool Equals(object obj) {
            if (!(obj is MyColor)) {
                return false;
            }

            var objColor = (MyColor)obj;
            return this.Color.R == objColor.Color.R && this.Color.G == objColor.Color.G && this.Color.B == objColor.Color.B;
        }
    }

}
