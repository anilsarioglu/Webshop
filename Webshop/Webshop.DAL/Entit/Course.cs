namespace Webshop.DAL.Entit
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Course(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
