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
using Dentists.View.Patient;

namespace Dentists
{
    /// <summary>
    /// RibbonWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RibbonWindow : Window
    {
        private MainViewModel vm = new MainViewModel();
        public RibbonWindow()
        {
            InitializeComponent();

            this.basicPage.DataContext = vm;
        }



        void vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CurrentContent")
            {
                this.ContentPanel.Children.Clear();
                this.ContentPanel.Children.Add(((MainViewModel)DataContext).CurrentContent);
            }
        }

        
    }
}
