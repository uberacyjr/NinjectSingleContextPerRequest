using System.ComponentModel.DataAnnotations;

namespace SingleContextPerRequest.Repository.Context.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
