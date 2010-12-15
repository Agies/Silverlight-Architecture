using System.ComponentModel.Composition;

namespace SilverlightArchitecture
{
    [Export]
    public partial class MainPage
    {
        private bool initialized;
        
        [Import]
        public ExampleViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (initialized) return;
            initialized = true;

            DataContext = ViewModel;
        }
    }
}
