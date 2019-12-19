using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MatrixOperations.ViewModels;
using MatrixOperations.Views;

namespace MatrixOperations
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainView view = new MainView();
            view.DataContext = new MainVM();
            view.Show();
        }
    }

}
