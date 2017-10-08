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

        public PersonRepo(TestContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            var persons = _context.Person.ToList();
            return persons;
        }

        public void Insert(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }
    }
}
