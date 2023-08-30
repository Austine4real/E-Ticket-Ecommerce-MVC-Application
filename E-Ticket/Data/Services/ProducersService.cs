using E_Ticket.Data.Base;
using E_Ticket.Models;

namespace E_Ticket.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
