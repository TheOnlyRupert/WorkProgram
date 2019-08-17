using WorkProgram.Source.ViewModel;

namespace WorkProgram.Source.Module {
    public partial class Schedule {
        public Schedule() {
            InitializeComponent();

            DataContext = new ScheduleVM();
        }
    }
}