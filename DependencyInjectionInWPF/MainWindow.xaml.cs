using DataAccessLibrary;
using System.Windows;

namespace DependencyInjectionInWPF
{  
    public partial class MainWindow : Window
    {
        private readonly IDataAccess _dataAccess;
        public MainWindow(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            InitializeComponent();
        }

        private void OnGetDataClick(object sender, RoutedEventArgs e)
        {
            tbData.Text = _dataAccess.GetData();
        }
    }
}