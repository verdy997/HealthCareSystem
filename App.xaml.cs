using HealthCareSystem.Model;
using HealthCareSystem.ViewModels;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HealthCareSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextViewModel context = new DbContextViewModel();

            MainWindow = new LogInView() //new PatientsListView()
            {
                DataContext = new LogInViewModel(),//PatientListViewModel()
                Context = context
                
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
