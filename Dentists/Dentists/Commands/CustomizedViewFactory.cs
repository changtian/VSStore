using Dentists.View.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Dentists.Commands
{
    public class CustomizedViewFactory
    {
        private static CustomizedViewFactory instance = null;
        private Dictionary<string, UserControl> views = new Dictionary<string, UserControl>(StringComparer.OrdinalIgnoreCase);
        public static CustomizedViewFactory Instance
        {
            get 
            {
                if (instance == null)
                    instance = new CustomizedViewFactory();
                return instance;
            }
        }

        private CustomizedViewFactory()
        { }

        public UserControl GetCustomizedView(string caption)
        {
            if (caption == "所有患者")
            {
                return new AllPatientView();                
            }
            if (caption == "添加患者")
            {
                return new NewPatientView();
            }
            return null;
        }
    }
}
