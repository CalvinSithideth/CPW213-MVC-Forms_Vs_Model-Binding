using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Forms_Vs_Model_Binding.Models;

namespace MVC_Forms_Vs_Model_Binding.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        // When data is posted to /Vehicles/New
        // this action will execute
        [HttpPost]
        public IActionResult New(IFormCollection data)
        {
            // Validate input (lots of work!)
            // Server-side and client-side
            // Add error messages on page to notify user

            Vehicle newVehicle = new Vehicle()
            {
                Brand  = data["brand"],
                ModelName = data["modelName"],
                Year = Convert.ToInt32(data["year"]),
                TotalMileage = Convert.ToInt32(data["totalMileage"]),
                Price = Convert.ToInt32(data["price"])

            };

            // Add to database
            VehicleDBC.InsertNewVehicle(newVehicle);
            ViewData["Success"] = "Vehicle was successfully registered!";
            return View();
        }

        [HttpGet]
        public IActionResult NewMB()
        {
            return View();
        }


        [HttpPost]
        public IActionResult NewMB(Vehicle newVehicle)
        {
            if (ModelState.IsValid)
            {
                // Add to database
                VehicleDBC.InsertNewVehicle(newVehicle);
                ViewData["Success"] = "Vehicle was successfully registered!";
                return View();
            }
            return View();
        }
    }
}