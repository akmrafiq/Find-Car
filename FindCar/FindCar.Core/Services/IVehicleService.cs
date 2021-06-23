using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Entities;

namespace FindCar.Core.Services
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAll();
    }
}
