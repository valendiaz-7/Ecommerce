
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

        public async Task<IList<Publicacion>> GetAllPublicaciones()
        {
            try
            {
                return await _context.Publicacion.Include(x => x.IdProductoNavigation).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

    }
}