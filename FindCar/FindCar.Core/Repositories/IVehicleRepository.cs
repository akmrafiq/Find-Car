using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Context;
using FindCar.Core.Entities;
using FindCar.Data;

namespace FindCar.Core.Repositories
{
    public interface IVehicleRepository: IRepository<Vehicle,int,FinderContext>
    {
        
    }
}
