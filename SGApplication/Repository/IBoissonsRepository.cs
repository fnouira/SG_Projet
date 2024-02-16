using SGApplication.Data.Boissons;

namespace SGApplication.Repository
{
    public interface IBoissonsRepository
    {
        List<BoissonsModel> GetAllBoisson();
    }
}
