using SingleContextPerRequest.Repository.Context;
using SingleContextPerRequest.Repository.Context.Model;
using SingleContextPerRequest.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SingleContextPerRequest.Repository.Repositorys
{
    public class CarRepo : ICar
    {

        private readonly TestContext _context;

        public CarRepo(TestContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
           var cars = _context.Car.ToList();
            return cars;
        }

        public void Insert(Car car)
        {
            _context.Car.Add(car);
            _context.SaveChanges();
        }
    }
}
