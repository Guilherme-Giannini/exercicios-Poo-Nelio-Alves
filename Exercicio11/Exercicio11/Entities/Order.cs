using Exercicio11.Entities.Enums;

namespace Exercicio11.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        override public string ToString()
        {
            return Id
                + ", "
                + Moment.ToString("dd/MM/yyyy HH:mm:ss")
                + ", "
                + Status;
        }
    }
}
