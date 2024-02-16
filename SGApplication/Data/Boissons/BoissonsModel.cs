using System.ComponentModel.DataAnnotations;

namespace SGApplication.Data.Boissons
{
    public class BoissonsModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
