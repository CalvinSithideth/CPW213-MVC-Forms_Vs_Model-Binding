using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Forms_Vs_Model_Binding.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        public string Brand { get; set; }

        public string ModelName { get; set; }

        public int Year { get; set; }

        public int TotalMileage { get; set; }

        public decimal Price { get; set; }
    }
}
