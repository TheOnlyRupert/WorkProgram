using System.Collections.ObjectModel;
using WorkProgram.Source.ViewModel.Base;

namespace WorkProgram.Source.ViewModel {
    public class EmployeeVM : BaseViewModel {
        public EmployeeVM() {
            ObservableCollection<DataObject> list = new ObservableCollection<DataObject> {
                new DataObject {A = 6, B = 7, C = 5},
                new DataObject {A = 5, B = 8, C = 4},
                new DataObject {A = 4, B = 3, C = 0}
            };

            //dataGrid1.ItemsSource = list;
        }

        public class DataObject {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }
        }
    }
}