using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SGApplication.Data;
using SGApplication.Data.Boissons;
using SGApplication.Service;

namespace SGApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoissonsController : ControllerBase
    {
        private readonly IBoissonsService _service;
        public BoissonsController(IBoissonsService service)
        {
            this._service = service;
        }
        [HttpPost]
        public IActionResult GetBoissonsByName([FromBody] BoissonsCommande request)
        {
            if(request.commande.ToUpper() == BoissonsType.EXPRESSO.ToUpper())
            {
                var response = this._service.IsExpresso(request);
                return Ok(response);
            }
            else if (request.commande.ToUpper() == BoissonsType.ALLONGE.ToUpper())
            {
                var response = this._service.IsAllonge(request);
                return Ok(response);
            }
            else if (request.commande.ToUpper() == BoissonsType.CAPUCCINO.ToUpper())
            {
                var response = this._service.IsCapuccino(request);
                return Ok(response);
            }
            else if(request.commande.ToUpper() == BoissonsType.CHOCOLAT.ToUpper())
            {
                var response = this._service.IsChocolat(request);
                return Ok(response);
            }
            else if(request.commande.ToUpper() == BoissonsType.THE.ToUpper())
            {
                var response = this._service.IsThe(request);
                return Ok(response);
            }
            else
            {
                return BadRequest("Boissons non disponible");
            }
        }
    }
}
