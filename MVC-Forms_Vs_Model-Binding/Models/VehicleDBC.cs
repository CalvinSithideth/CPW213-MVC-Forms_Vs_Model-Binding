using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Forms_Vs_Model_Binding.Models
{
    public static class VehicleDBC
    {
        public static void InsertNewVehicle(Vehicle newVehicle)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SimpleVehicleDatabase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"INSERT INTO Vehicles (Brand, [Year], TotalMileage, ModelName, Price) " +
                                            $"VALUES (@Brand, @Year, @TotalMileage, @ModelName, @Price)");
            cmd.Parameters.AddWithValue("@Brand", newVehicle.Brand);
            cmd.Parameters.AddWithValue("@Year", newVehicle.Year);
            cmd.Parameters.AddWithValue("@TotalMileage", newVehicle.TotalMileage);
            cmd.Parameters.AddWithValue("@ModelName", newVehicle.ModelName);
            cmd.Parameters.AddWithValue("@Price", newVehicle.Price);

            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
