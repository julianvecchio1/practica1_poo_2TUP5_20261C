using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    
    [HttpGet("conducir")]
    public ActionResult<string> Conducir(int combustible)
    {
        IVehiculo coche = new Coche(combustible);

        return Ok(coche.Conducir());
    }

    
    [HttpGet("cargar")]
    public ActionResult<string> CargarYConducir(int cantidad)
    {
        IVehiculo coche = new Coche(0);

        coche.CargarCombustible(cantidad);

        return Ok(coche.Conducir());
    }
}