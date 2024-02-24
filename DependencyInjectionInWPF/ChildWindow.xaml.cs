using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace DependencyInjectionInWPF
{   
    public partial class ChildWindow : Window
    {
        private readonly IDataAccess _dataAccess;
        public ChildWindow(IDataAccess dataAccess)
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
