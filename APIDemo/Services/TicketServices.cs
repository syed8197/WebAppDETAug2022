using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; set; }

        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Bookedfor = "PlatinumPlus", Price = 5000, Qty = 200 },
                new Ticket { Id = 2, Bookedfor = "Platinum", Price = 4000, Qty = 30 },
                new Ticket { Id = 3, Bookedfor = "Gold", Price = 3000, Qty = 500 },
                new Ticket { Id = 4, Bookedfor = "Silver", Price = 2000, Qty = 50 },
                new Ticket { Id = 5, Bookedfor = "General", Price = 1000, Qty = 20 }
            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int Id)
        {
            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == Id);
            return ticket;
        }
    }
}
