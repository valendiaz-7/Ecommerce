
using DataAccess.IRepository;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class PublicacionRepository : GenericRepository<Publicacion>, IPublicacionRepository
    {
        public PublicacionRepository(EcommercedbContext context) : base(context)
        {
        }

        

    }
}