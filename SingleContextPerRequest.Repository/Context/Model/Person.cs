using System.ComponentModel.DataAnnotations;

namespace SingleContextPerRequest.Repository.Context.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
