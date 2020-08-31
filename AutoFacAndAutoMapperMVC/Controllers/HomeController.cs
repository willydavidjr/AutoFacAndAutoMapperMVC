using AutoFacAndAutoMapperMVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacAndAutoMapperMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            //This entity object can come from Database or any related source
            var person = new Person()
            {
                Id = 1,
                FirstName = "Cecilia",
                LastName = "Chapman",
                Address = "32 West Court Street",
                City = "Dallas",
                State = "GA",
                Country = "USA",
                DateOfBirth = new DateTime(1981, 1, 5),
                HighestEducation = "College Graduate",
                MaritalStatus = "Married",
                PhoneNumber = "+1-541-754-3010"
            };

            var model1 = new List<Person>().Select(x => new PersonViewModel()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Country = x.Country,
                HighestEducation = x.HighestEducation,
                MaritalStatus = x.MaritalStatus
            });

            var model = _mapper.Map<PersonViewModel>(person);
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}