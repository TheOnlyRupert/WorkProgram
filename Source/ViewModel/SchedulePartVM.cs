using WorkProgram.Source.ViewModel.Base;

namespace WorkProgram.Source.ViewModel {
    public class SchedulePartVM : BaseViewModel {
        private readonly CrossViewMessenger _crossViewMessenger;

        private string _mainInfo, _timeStart, _timeEnd, _timeTotal;

        public SchedulePartVM() {
            MainInfo = "D. Price #1000        Mon, 2020-01-01";
            TimeStart = "0000";
            TimeEnd = "0800";
            TimeTotal = "8.0";

            _crossViewMessenger = CrossViewMessenger.Instance;
            _crossViewMessenger.MessageValueChanged += OnSimpleMessengerValueChanged;
        }

        public string MainInfo {
            get => _mainInfo;
            set {
                _mainInfo = value;
                RaisePropertyChangedEvent("MainInfo");
            }
        }

        public string TimeStart {
            get => _timeStart;
            set {
                _timeStart = value;
                RaisePropertyChangedEvent("TimeStart");
            }
        }

        public string TimeEnd {
            get => _timeEnd;
            set {
                _timeEnd = value;
                RaisePropertyChangedEvent("TimeEnd");
            }
        }

        public string TimeTotal {
            get => _timeTotal;
            set {
                _timeTotal = value;
                RaisePropertyChangedEvent("TimeTotal");
            }
        }

        private void OnSimpleMessengerValueChanged(object sender, MessageValueChangedEventArgs e) {
            switch (e.PropertyName) { }
        }
    }
}