using SGApplication.Data.Boissons;
using SGApplication.Data.Context;

namespace SGApplication.Repository
{
    public class BoissonRepository : IBoissonsRepository
    {
        private readonly BoissonsDbContext _context;
        public BoissonRepository(BoissonsDbContext context)
        {
            this._context = context;
        }

        List<BoissonsModel> IBoissonsRepository.GetAllBoisson()
        {
            return this._context.Boissons.ToList();

        }
    }
}
