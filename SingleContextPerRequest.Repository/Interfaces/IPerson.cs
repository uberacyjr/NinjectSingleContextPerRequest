using SingleContextPerRequest.Repository.Context.Model;
using System.Collections.Generic;

namespace SingleContextPerRequest.Repository.Interfaces
{
    public interface IPerson
    {
        IEnumerable<Person> GetAllPersons();
        void Insert(Person person);
    }
}
