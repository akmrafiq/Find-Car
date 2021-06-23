using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Context;
using FindCar.Core.Repositories;
using FindCar.Data;
using Microsoft.EntityFrameworkCore;

namespace FindCar.Core.UnitOfWorks
{
    public class FinderUnitOfWork:UnitOfWork, IFinderUnitOfWork
    {
        public IVehicleRepository VehicleRepository { get; set; }

        public FinderUnitOfWork(
            FinderContext finderContext,
            IVehicleRepository vehicleRepository
            ) : base(finderContext)
        {
            VehicleRepository = vehicleRepository;
        }
    }
}
