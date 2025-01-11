using Microsoft.EntityFrameworkCore;
using MovieTicketsWebApp.Data.Base;
using MovieTicketsWebApp.Models;
using Polly;

namespace MovieTicketsWebApp.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(AppDbContext context) : base(context) { }
       
    }
}
