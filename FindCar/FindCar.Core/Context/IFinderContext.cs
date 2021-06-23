using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FindCar.Core.Context
{
    public interface IFinderContext
    {
        DbSet<Vehicle> Vehicles { get; set; }
    }
}
