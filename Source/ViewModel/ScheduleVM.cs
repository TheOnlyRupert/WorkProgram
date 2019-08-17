using System;
using System.Globalization;
using WorkProgram.Source.ViewModel.Base;

namespace WorkProgram.Source.ViewModel {
    public class ScheduleVM : BaseViewModel {
        private readonly CrossViewMessenger _crossViewMessenger;

        private string _iconImage, _startDate0, _startDate1, _startDate2, _startDate3, _startDate4, _startDate5,
            _startDate6, _startDate7, _testEmployee0;

        public ScheduleVM() {
            IconImage = "Resources/icons/icon.png";
            TestEmployee0 = "D. Price\n40.0";

            StartDate0 = DateTime.Today.ToString(CultureInfo.InvariantCulture);
            /* Change rest of dates to reflect new start date */
            StartDate1 = "Monday";


            _crossViewMessenger = CrossViewMessenger.Instance;
            _crossViewMessenger.MessageValueChanged += OnSimpleMessengerValueChanged;
        }

        public string IconImage {
            get => _iconImage;
            set {
                _iconImage = value;
                RaisePropertyChangedEvent("IconImage");
            }
        }

        public string StartDate0 {
            get => _startDate0;
            set {
                _startDate0 = value;
                RaisePropertyChangedEvent("StartDate0");
            }
        }

        public string StartDate1 {
            get => _startDate1;
            set {
                _startDate1 = value;
                RaisePropertyChangedEvent("StartDate1");
            }
        }

        public string StartDate2 {
            get => _startDate2;
            set {
                _startDate2 = value;
                RaisePropertyChangedEvent("StartDate2");
            }
        }

        public string StartDate3 {
            get => _startDate3;
            set {
                _startDate3 = value;
                RaisePropertyChangedEvent("StartDate3");
            }
        }

        public string StartDate4 {
            get => _startDate4;
            set {
                _startDate4 = value;
                RaisePropertyChangedEvent("StartDate4");
            }
        }

        public string StartDate5 {
            get => _startDate5;
            set {
                _startDate5 = value;
                RaisePropertyChangedEvent("StartDate5");
            }
        }

        public string StartDate6 {
            get => _startDate6;
            set {
                _startDate6 = value;
                RaisePropertyChangedEvent("StartDate6");
            }
        }

        public string StartDate7 {
            get => _startDate7;
            set {
                _startDate7 = value;
                RaisePropertyChangedEvent("StartDate7");
            }
        }

        public string TestEmployee0 {
            get => _testEmployee0;
            set {
                _testEmployee0 = value;
                RaisePropertyChangedEvent("TestEmployee0");
            }
        }

        private void OnSimpleMessengerValueChanged(object sender, MessageValueChangedEventArgs e) {
            switch (e.PropertyName) { }
        }
    }
}