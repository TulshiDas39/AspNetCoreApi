using AspNetCoreApi.Core.Interfaces.Repositories;
using AspNetCoreApi.Repositories.Context;
using Core.Models;

namespace AspNetCoreApi.Repositories
{
    public class CowRepository : BaseRepository<Cow>, ICowRepository
    {
        public CowRepository(AppDbContext context) : base(context)
        {

        }
    }
}