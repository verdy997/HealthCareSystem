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
    /// Interaction logic for Examination.xaml
    /// </summary>
    public partial class ExaminationView : Window
    {
        public ExaminationView()
        {
            InitializeComponent();
        }

        private void AddPrescription(object sender, RoutedEventArgs e)
        {
            PrescriptionView prescription = new PrescriptionView();
            prescription.Show();
        }

        private void AddWorkInability(object sender, RoutedEventArgs e)
        {
            WorkInabilityView workInabilityWin = new WorkInabilityView();
            workInabilityWin.Show();
        }
    }
}
