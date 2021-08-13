using Gun5.Odev5_1.GameOrder.Abstract;

namespace Gun5.Odev5_1.GameOrder.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

    }
}