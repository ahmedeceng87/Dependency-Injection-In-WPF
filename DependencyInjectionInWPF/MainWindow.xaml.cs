using DataAccessLibrary;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace DependencyInjectionInWPF
{  
    public partial class MainWindow : Window
    {
        private readonly IDataAccess _dataAccess;
        private readonly IServiceProvider _serviceProvider;
        public MainWindow(IDataAccess dataAccess, IServiceProvider serviceProvider)
        {
            _dataAccess = dataAccess;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void OnGetDataClick(object sender, RoutedEventArgs e)
        {
            tbData.Text = _dataAccess.GetData();
        }

        private void OpenChildWindowOnClick(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetService<ChildWindow>().Show();
        }
    }
}