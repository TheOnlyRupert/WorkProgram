using WorkProgram.Source.ViewModel;

namespace WorkProgram.Source.Module {
    public partial class EmployeePart {
        public EmployeePart() {
            InitializeComponent();

            DataContext = new EmployeePartVM();
        }
    }
}