using SingleContextPerRequest.Repository.Context;
using SingleContextPerRequest.Repository.Context.Model;
using SingleContextPerRequest.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SingleContextPerRequest.Repository.Repositorys
{
    public class PersonRepo : IPerson
    {
        private readonly TestContext _context;
        private readonly ICar _carRepo;

        public PersonRepo(TestContext context, ICar carRepo)
        {
            _context = context;
            _carRepo = carRepo;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            var persons = _context.Person.ToList();
            return persons;
        }

        public void Insert(Person person)
        {
            using (var transaction =  _context.Database.BeginTransaction())
            {
                _context.Car.Add(new Car { Name = "Gol 1.6" });
                _context.Person.Add(person);
                _context.SaveChanges();

                _carRepo.Insert(new Car {Name = "BMW"});

                transaction.Commit();
            }
        
        }
    }
}
