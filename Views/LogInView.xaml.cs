using HealthCareSystem.Model;
using HealthCareSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HealthCareSystem
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        public DbContextViewModel Context { get; set; }

        public LogInView()
        {
            InitializeComponent();
        }

        private void SingIn(object sender, RoutedEventArgs e)
        {
            int tmp = int.Parse(LogName.Text);

            if (Context.Context.Doctors.Where(x => x.ID == tmp).Any())
            {
                Doctor doctor = Context.Context.Doctors.Where(x => x.ID == tmp).First();
                if (doctor != null && doctor.Password == Password.Password)
                {
                    Ambulance ambulance = Context.Context.Ambulances.Where(x => x.Doctor == doctor).First();
                    BasicView mainWindow = new BasicView();
                    mainWindow.DataContext = new BasicViewModel(ambulance, doctor, Context);
                    mainWindow.Show();
                    this.Close();
                } else
                {
                    var result = MessageBox.Show("Nesprávne ID alebo heslo!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }

            //if (doctor.Password == Password.Password )
            //{
            //    Ambulance ambulance = Context.Context.Ambulances.Where(x => x.Doctor == doctor).First();
            //    BasicView mainWindow = new BasicView();
            //    mainWindow.DataContext = new BasicViewModel(ambulance, doctor);
            //    mainWindow.Show();
            //    this.Close();
            //}

            //if (Context.Context.Doctors.Where(x => x.Password == Password.Password).Any())
            //{
            //    //var doctor = new Doctor(1, "admin", "Bartolomej", "Nutý");
            //    //var ambulance = new Ambulance(1, "Vseobecna Ambulancia", "Na troskach 25, BB", doctor);
            //    //var pt1 = new Patient("Jozko", "Mrkvicka", 9706084895, "Muž", "Holubčia 5", "Zvolen", 98065, 0948268973, "mrkvicka@gmail.com", 27, 183, 95, "Nezamestnaný", "");
            //    //var wi = new WorkInability(5, pt1, $"{pt1.Street}, {pt1.City}", "spadol na hlavu prudko", DateTime.Today, DateTime.Today.AddDays(-6), DateTime.Today, true);
            //    //var wi2 = new WorkInability(5, pt1, $"{pt1.Street}, {pt1.City}", "spadol na ruku prudko a zlomil si ju", DateTime.Today, DateTime.Today, DateTime.Today.AddDays(5), false);
            //    //var ex = new Examination(1, ambulance, doctor, pt1, "boli ho ruka", "minul som obvaz", "pacient spadol na ruku ked hrabal listie, spadol zo stromu");
            //    //var vac = new Vaccination("Covid-19", pt1, DateTime.Today.AddMonths(-7));
            //    //var vac2 = new Vaccination("Covid-19", pt1, DateTime.Today.AddMonths(-4));
            //    //var dr = new Drug("asdgf5", "Nootropil");
            //    //var pr = new Prescription(5, doctor, pt1, DateTime.Today.AddMonths(-4), dr);
            //    //pt1.Prescriptions.Add(pr);
            //    //pt1.Vaccinations.Add(vac);
            //    //pt1.Vaccinations.Add(vac2);
            //    //pt1.Examinations.Add(ex);
            //    //pt1.WorkInabilities.Add(wi);
            //    //pt1.WorkInabilities.Add(wi2);
            //    //var pt2 = new Patient("Jan", "Ferko", 9206084895, "Muž", "Prchav 1", "Trnava", 98095, 0948268972, "jferko@gmail.com", 27, 172, 88, "Spolocna.s.r.o", "Lepok");
            //    //var pt3 = new Patient("Brontoslava", "Ferková", 9306584895, "Žena", "Prchav 1", "Trnava", 98095, 0948268972, "bferkova@gmail.com", 27, 158, 60, "Spolocna.s.r.o", "Penicilin");
            //    //ambulance.Patients.Add(pt1);
            //    //ambulance.Patients.Add(pt2);
            //    //ambulance.Patients.Add(pt3);

                

                
            //}
        }
    }
}
