using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Data;

namespace FindCar.Core.Entities
{
    public class Vehicle : IEntity<int>
    {
        public int Id { get; set; }
        public string VehicleClass { get; set; }    
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
