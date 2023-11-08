using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    class MainWindowViewModel : ViewModel{
        //private double merticValue, imperialValue;
        private double gramValue, poundValue;

        //public ICommand ImperialUnitToMetric { get; private set; }
        //public ICommand MetricToImperialUnit { get; private set; }

        public ICommand PoundUnitToGram{ get; private set; }
        public ICommand GramToPoundUnit{ get; private set; }


        //public MetricUnit CurrentMetricUnit { get; set; }
        //public ImperialUnit CurrentImperialUnit { get; set; }

        public GramUnit CurrentGramUnit { get; set; }
        public PoundUnit CurrentPoundUnit { get; set; }

        //public double metricvalue {
        //    get { return this.merticvalue; }
        //    set { this.merticvalue = value;
        //        this.onpropertychanged (); } 
        //}
        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged ();
            }
        }


        //public double ImperialValue {
        //    get { return this.imperialValue; }
        //    set {
        //        this.imperialValue = value;
        //        this.OnPropertyChanged (); }
        //}

        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged ();
            }
        }

        public MainWindowViewModel() {
            //this.CurrentMetricUnit = MetricUnit.Units.First ();
            //this.CurrentImperialUnit = ImperialUnit.Units.First ();
            //this.MetricToImperialUnit = new DelegateCommand (
            //    () => this.ImperialValue = this.CurrentImperialUnit.FromMetricUnit ( this.CurrentMetricUnit, this.MetricValue ) );

            //this.ImperialUnitToMetric = new DelegateCommand (
            //    () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit ( this.CurrentImperialUnit, this.ImperialValue ) );

            this.CurrentGramUnit = GramUnit.Units.First ();
            this.CurrentPoundUnit = PoundUnit.Units.First ();
            this.GramToPoundUnit = new DelegateCommand (
                () => this.PoundValue = this.CurrentPoundUnit.FromGramUnit ( this.CurrentGramUnit, this.GramValue ) );

            this.PoundUnitToGram= new DelegateCommand (
                () => this.GramValue = this.CurrentGramUnit.FromPoundUnit( this.CurrentPoundUnit, this.PoundValue ) );

        }
    }
}
