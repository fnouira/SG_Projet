using SGApplication.Data.Boissons;

namespace SGApplication.Service
{
    public interface IBoissonsService
    {
        double IsExpresso(BoissonsCommande commande);
        double IsAllonge(BoissonsCommande commande);
        double IsCapuccino(BoissonsCommande commande);
        double IsChocolat(BoissonsCommande commande);
        double IsThe(BoissonsCommande commande);

    }
}
