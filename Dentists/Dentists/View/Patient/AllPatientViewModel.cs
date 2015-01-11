using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using Dentists.Models.Patient;

namespace Dentists.View.Patient
{
    public class AllPatientViewModel : ViewModelBase
    {
        List<Dentists.Models.Patient.Patient> AllPatients { get; set; }

        public AllPatientViewModel()
        {
            AllPatients = new List<Models.Patient.Patient>();
            AllPatients.Add(new Models.Patient.Patient { Age = 21, Disease = "ÑÀÌÛ", Gender = "ÄÐ", PatientID = "0" });
        }
    }
}