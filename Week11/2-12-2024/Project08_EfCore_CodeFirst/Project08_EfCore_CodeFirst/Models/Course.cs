namespace Project08_EfCore_CodeFirst.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
