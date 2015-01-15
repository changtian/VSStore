using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dentists.Commands;
using Dentists.View.Patient;

namespace Dentists
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private UIElement currentContent = new UIElement();
        public UIElement CurrentContent
        {
            get { return currentContent; }
            set
            {
                currentContent = value;
                RaisePropertyChanged("CurrentContent");
            }
        }

        public RelayCommand NewPatientCommand;
        public RelayCommand AllPatientsCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainViewModel()
        {
            NewPatientCommand = new RelayCommand((o) =>
            {
                NewPatientView npv = new NewPatientView();
                CurrentContent = npv as UIElement;
            }, (o) => { return true; });

            AllPatientsCommand = new RelayCommand((o) =>
            {
                AllPatientView apv = new AllPatientView();
                CurrentContent = apv as UIElement;
            }, (o) => { return true; });
        }
    }
}
