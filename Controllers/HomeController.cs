using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSystemExercise.Models;

namespace PatientSystemExercise.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            @ViewBag.Title = "Registration";
            return View();
        }

        [HttpPost]
        public ViewResult Register(Patient patient)
        {
            PatientRespository.AddPatient(patient);
            return View("ThankYou", patient);
        }

        public ViewResult List()
        {
            @ViewBag.Title = "Patient List";
            return View(PatientRespository.Patients);
        }
    }
}
