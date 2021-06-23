using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FindCar.Data
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Save();
        Task SaveAsync();
    }
}
