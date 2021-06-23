using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Repositories;
using FindCar.Data;

namespace FindCar.Core.UnitOfWorks
{
    public interface IFinderUnitOfWork:IUnitOfWork
    {
        IVehicleRepository VehicleRepository { get; set; }
    }
}
