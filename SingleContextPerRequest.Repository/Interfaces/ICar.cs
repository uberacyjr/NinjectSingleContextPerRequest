using SingleContextPerRequest.Repository.Context.Model;
using System.Collections.Generic;

namespace SingleContextPerRequest.Repository.Interfaces
{
    public interface ICar
    {
        IEnumerable<Car> GetAllCars();
        void Insert(Car car);
    }
}
