using E_Ticket.Data.Base;
using E_Ticket.Models;

namespace E_Ticket.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
