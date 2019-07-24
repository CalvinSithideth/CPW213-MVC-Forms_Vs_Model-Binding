using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Forms_Vs_Model_Binding.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        public int NumWheels { get; set; }

        public string DriveTrain { get; set; }

        public string Transmission { get; set; }

        public string Brand { get; set; }

        public string BrandCountry { get; set; }

        public int Year { get; set; }

        public int TotalMileage { get; set; }

        public bool IsNew { get; set; }

        public string ModelName { get; set; }

        public int CityMPG { get; set; }

        public int HwyMPG { get; set; }

        public decimal Price { get; set; }
    }
}
