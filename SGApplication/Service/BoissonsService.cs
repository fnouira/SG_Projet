using SGApplication.Data.Boissons;
using SGApplication.Repository;

namespace SGApplication.Service
{
    public class BoissonsService : IBoissonsService
    {
        private readonly IBoissonsRepository _repository;
        private double marge = 1.3;
        public BoissonsService(IBoissonsRepository repository)
        {
            this._repository = repository;
        }
        public double IsExpresso(BoissonsCommande commande)
        {
            try
            {
                var data = this._repository.GetAllBoisson();
                var expresso = data.Where(y => y.Name == "Cafe" || y.Name == "Eau").Select(x => x.Price).Sum();
                return Math.Round((expresso * marge),3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public double IsAllonge(BoissonsCommande commande)
        {
            try
            {
                var data = this._repository.GetAllBoisson();
                var cafe = data.Where(y => y.Name == "Cafe").Select(x => x.Price).FirstOrDefault();
                var eau = data.Where(y => y.Name == "Eau").Select(x => x.Price * 2).FirstOrDefault();
                var allonge = cafe + eau;
                return Math.Round((allonge * marge),3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double IsCapuccino(BoissonsCommande commande)
        {
            try
            {
                var data = this._repository.GetAllBoisson();
                var cafe = data.Where(y => y.Name == "Cafe").Select(x => x.Price).FirstOrDefault();
                var chocolat = data.Where(y => y.Name == "Chocolat").Select(x => x.Price).FirstOrDefault();
                var eau = data.Where(y => y.Name == "Eau").Select(x => x.Price).FirstOrDefault();
                var creme = data.Where(y => y.Name == "Creme").Select(x => x.Price).FirstOrDefault();
                var capuccino = cafe + chocolat + eau + creme + creme;
                return Math.Round((capuccino * marge),3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double IsChocolat(BoissonsCommande commande)
        {
            try
            {
                var data = this._repository.GetAllBoisson();
                var chocolat = data.Where(y => y.Name == "Chocolat").Select(x => x.Price * 3).FirstOrDefault();
                var lait = data.Where(y => y.Name == "Lait").Select(x => x.Price * 2).FirstOrDefault();
                var eau = data.Where(y => y.Name == "Eau").Select(x => x.Price).FirstOrDefault();
                var sucre = data.Where(y => y.Name == "Sucre").Select(x => x.Price).FirstOrDefault();
                var chocolats = chocolat + lait + eau + sucre;
                return Math.Round((chocolats * marge),3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double IsThe(BoissonsCommande commande)
        {
            try
            {
                var data = this._repository.GetAllBoisson();
                var the = data.Where(y => y.Name == "The").Select(x => x.Price).FirstOrDefault();
                var eau = data.Where(y => y.Name == "Eau").Select(x => x.Price * 2).FirstOrDefault();
                var Thes = the + eau ;
                return Math.Round((Thes * marge),3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
