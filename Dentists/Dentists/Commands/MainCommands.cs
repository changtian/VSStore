using Dentists.View.Patient;
using DevExpress.Xpf.Docking;
using GalaSoft.MvvmLight.Command;
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
            OpenDocCmd = new RelayCommand<string>((s) => { OpenDocument(s); });
            CloseDocCmd = new RelayCommand(CloseDocument, CanCloseDocument);
        }

        private bool CanCloseDocument(object obj)
        {
            return true;
        }

        private void CloseDocument(object obj)
        {
            vm.Documents.Remove(obj as DocumentPanel);
        }

        private void OpenDocument(string caption)
        {
            DocumentPanel newPatientPanel = new DocumentPanel();
            var view = CustomizedViewFactory.Instance.GetCustomizedView(caption);
            newPatientPanel.Caption = caption;
            newPatientPanel.Content = view;
            vm.Documents.Add(newPatientPanel);
            vm.DocumentsCount = vm.Documents.Count;
            newPatientPanel.IsActive = true;
            newPatientPanel.CloseCommand = CloseDocCmd;
        }

        public RelayCommand<string> OpenDocCmd { get; set; }
        public RelayCommand CloseDocCmd { get; set; }
    }
}
