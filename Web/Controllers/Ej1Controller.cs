using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller: ControllerBase
{

    [HttpGet]
    public List<string> Get(string persona1, string persona2, string persona3)
    {
        var l = new List<string>();
        l.Add("Esto es una prueba");
        l.Add("Esto es otra prueba");

        return l;
    }
}