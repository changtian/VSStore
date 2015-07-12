using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dentists.View.Patient
{
    /// <summary>
    /// Interaction logic for NewPatientView.xaml
    /// </summary>
    public partial class NewPatientView : UserControl
    {
        public NewPatientView()
        {
            InitializeComponent();
            Models.Patient.Patient person =new Models.Patient.Patient();
            this.DataContext = person; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var p = this.DataContext as Dentists.Models.Patient.Patient;
            Dentists.DataContext.DentistEntities dbContext = new DataContext.DentistEntities();
            p.DiagnosisDate = DateTime.Now;
            dbContext.Patients.Add(p);
            dbContext.SaveChanges();
        }
    }
}
