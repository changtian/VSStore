using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Dentists.Commands;
using Dentists.View.Patient;
using GalaSoft.MvvmLight;
using System.Windows.Threading;
using Dentists.Common.Collections;
using GalaSoft.MvvmLight.Ioc;
using DevExpress.Xpf.Docking;
using System.Collections.ObjectModel;

namespace Dentists
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<DocumentPanel> documents;
        public ObservableCollection<DocumentPanel> Documents 
        {
            get {
                if (documents == null)
                    documents = new ObservableCollection<DocumentPanel>();
                return documents;
            }
            set
            {
                Set<ObservableCollection<DocumentPanel>>("Documents", ref documents, value);
            }
        }

        private int documentsCount;
        public int DocumentsCount
        {
            get { return documentsCount; }
            set { Set<int>("DocumentsCount", ref documentsCount, value); }
        }

        private MainCommands commands = null;
        public MainCommands Commands
        {
            get
            {
                if (commands == null)
                {
                    SimpleIoc.Default.Register<MainCommands>();
                    commands = SimpleIoc.Default.GetInstance<MainCommands>();
                }
                return commands;
            }
        }
        
        public MainViewModel()
        {
        }
    }
}
