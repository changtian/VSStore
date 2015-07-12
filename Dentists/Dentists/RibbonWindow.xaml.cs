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
using GalaSoft.MvvmLight.Ioc;
using DDDInfrastructure;

namespace Dentists
{
    /// <summary>
    /// RibbonWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RibbonWindow : Window
    {
        private MainViewModel vm ;
        public RibbonWindow()
        {
            InitializeComponent();
            SimpleIoc.Default.Register<MainViewModel>(() => { return new MainViewModel(); }, Constants.MainViewModelKey, true);
            SimpleIoc.Default.Register< IRepositoryContext>(() => { return new EntityFrameworkRepositoryContext(new DataContext.DentistEntities()); }, Constants.RepositoryContext, true);
            vm = SimpleIoc.Default.GetInstance<MainViewModel>(Constants.MainViewModelKey);
            this.Loaded += RibbonWindow_Loaded;
        }

        void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = vm;
        }


        
    }
}
