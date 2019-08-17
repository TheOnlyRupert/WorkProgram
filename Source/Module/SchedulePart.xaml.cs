using WorkProgram.Source.ViewModel;

namespace WorkProgram.Source.Module {
    public partial class SchedulePart {
        public SchedulePart() {
            InitializeComponent();

            DataContext = new SchedulePartVM();
        }
    }
}