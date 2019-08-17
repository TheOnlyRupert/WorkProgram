using WorkProgram.Source.ViewModel;

namespace WorkProgram {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();

            DataContext = new MainWindowVM();
        }
    }
}