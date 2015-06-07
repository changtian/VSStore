using Dentists.View.Patient;
using DevExpress.Xpf.Docking;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentists.Commands
{
    public class MainCommands
    {
        private MainViewModel vm;
        public MainCommands()
        {
            vm = SimpleIoc.Default.GetInstance<MainViewModel>(Constants.MainViewModelKey);
            OpenAllPatientViewCmd = new RelayCommand(OpenAllPatientView, CanOpenAllPatientView);
        }

        private bool CanOpenAllPatientView(object obj)
        {
            return true;
        }

        private void OpenAllPatientView(object obj)
        {
            DocumentPanel allPatientPanel = new DocumentPanel();
            var view = new AllPatientView();
            allPatientPanel.Caption = "所有患者";
            allPatientPanel.Content = view;
            vm.Documents.Add(allPatientPanel);
            vm.DocumentsCount = vm.Documents.Count;
        }

        public RelayCommand OpenAllPatientViewCmd { get; set; }


    }
}
