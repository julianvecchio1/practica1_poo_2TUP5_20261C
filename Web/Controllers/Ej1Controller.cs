using Microsoft.AspNetCore.Mvc;
using Web.Ej1;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get(string persona1, string persona2, string persona3)
    {
        var personas = new List<Persona>
        {
            new Persona(persona1),
            new Persona(persona2),
            new Persona(persona3)
        };

        var saludos = new List<string>();

        foreach (var p in personas)
        {
            saludos.Add(p.GetSaludo());
        }

        return saludos;
    }
}