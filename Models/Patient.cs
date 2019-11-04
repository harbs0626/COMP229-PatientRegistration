using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystemExercise.Models
{
    public class Patient
    {
        public string PatientName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Occupation { get; set; }

        public bool HasInsurance { get; set; }

        public bool HadPreviousOperation { get; set; }

        public string MaritalStatus { get; set; }

        public DateTime CurrentDateAndTime { get; set; } = DateTime.Now;
    }
}
