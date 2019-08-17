using WorkProgram.Source.ViewModel;

namespace WorkProgram.Source.Module {
    public partial class Employee {
        public Employee() {
            InitializeComponent();

            DataContext = new EmployeeVM();
        }
    }
}