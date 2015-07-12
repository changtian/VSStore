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
    /// Interaction logic for AllPatientView.xaml
    /// </summary>
    public partial class AllPatientView : UserControl
    {
        public AllPatientView()
        {
            AllPatientViewModel vm = new AllPatientViewModel();
            InitializeComponent();
            DataContext = vm;
            this.GCAllPatients.ItemsSource = vm.AllPatients;
        }

    }
}
