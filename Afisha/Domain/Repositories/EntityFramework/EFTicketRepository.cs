using Afisha.Domain.Repositories.Abstract;
namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFTicketRepository:ITicketRepository
    {
        private readonly AppDbContext context;
        public EFTicketRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
