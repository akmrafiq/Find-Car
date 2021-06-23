using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Entities;
using FindCar.Core.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace FindCar.Core.Services
{
    public class VehicleService:IVehicleService
    {
        private readonly IFinderUnitOfWork _finderUnitOfWork;
        private readonly ILogger<VehicleService> _logger;

        public VehicleService(IFinderUnitOfWork finderUnitOfWork, ILogger<VehicleService> logger)
        {
            _finderUnitOfWork = finderUnitOfWork;
            _logger = logger;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _finderUnitOfWork.VehicleRepository.GetAll();
        }
    }
}
