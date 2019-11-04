using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystemExercise.Models
{
    public static class PatientRespository
    {
        //** 1. Set List
        private static List<Patient> patients = 
            new List<Patient>();

        //** 2. Pass List to IEnumerable
        public static IEnumerable<Patient> Patients
        {
            get
            {
                return patients;
            }
        }

        //** 3. Add Patients to List
        public static void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }
    }
}
