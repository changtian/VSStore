using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using Dentists.Models.Patient;
using DDDInfrastructure;
using DDDInfrastructure.Extensions;
using Dentists.Common.Collections;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Ioc;

namespace Dentists.View.Patient
{
    public class AllPatientViewModel : ViewModelBase
    {
        private ObservableCollection<Dentists.Models.Patient.Patient> allPatients = null;
        public ObservableCollection<Dentists.Models.Patient.Patient> AllPatients
        {
            get
            {
                if (allPatients == null)
                { allPatients = new ObservableCollection<Models.Patient.Patient>(); }
                return allPatients;
            }
            set { allPatients = value; }
        }

        private EntityFrameworkRepository<Dentists.Models.Patient.Patient> repository;
        private EntityFrameworkRepository<Dentists.Models.Patient.Patient> Repository
        {
            get 
            {
                if (repository == null)
                {
                    repository = new EntityFrameworkRepository<Models.Patient.Patient>(SimpleIoc.Default.GetInstance<IRepositoryContext>(Constants.RepositoryContext));
                }
                return repository;
            }
        }

        public AllPatientViewModel()
        {
            foreach (var item in Repository.FindAll())
            {
                AllPatients.Add(item);
            }
        }
    }
}