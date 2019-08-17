using WorkProgram.Source.ViewModel.Base;

namespace WorkProgram.Source.ViewModel {
    public class EmployeePartVM : BaseViewModel {
        private readonly CrossViewMessenger _crossViewMessenger;

        private string _employeeID, _nameFir, _nameMid, _nameLas, _badge, _activeButtonText;

        public EmployeePartVM() {
            EmployeeID = "Employee #1";

            NameFir = "Darnell";
            NameMid = "John";
            NameLas = "Price";
            Badge = "1000";

            ActiveButtonText = "True";

            _crossViewMessenger = CrossViewMessenger.Instance;
            _crossViewMessenger.MessageValueChanged += OnSimpleMessengerValueChanged;
        }

        public string EmployeeID {
            get => _employeeID;
            set {
                _employeeID = value;
                RaisePropertyChangedEvent("EmployeeID");
            }
        }

        public string NameFir {
            get => _nameFir;
            set {
                _nameFir = value;
                RaisePropertyChangedEvent("NameFir");
            }
        }

        public string NameMid {
            get => _nameMid;
            set {
                _nameMid = value;
                RaisePropertyChangedEvent("NameMid");
            }
        }

        public string NameLas {
            get => _nameLas;
            set {
                _nameLas = value;
                RaisePropertyChangedEvent("NameLas");
            }
        }

        public string Badge {
            get => _badge;
            set {
                _badge = value;
                RaisePropertyChangedEvent("Badge");
            }
        }

        public string ActiveButtonText {
            get => _activeButtonText;
            set {
                _activeButtonText = value;
                RaisePropertyChangedEvent("ActiveButtonText");
            }
        }

        private void OnSimpleMessengerValueChanged(object sender, MessageValueChangedEventArgs e) {
            switch (e.PropertyName) { }
        }
    }
}