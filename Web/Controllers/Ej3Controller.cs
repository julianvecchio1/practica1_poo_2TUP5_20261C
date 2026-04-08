using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    // ✅ Crear Persona
    [HttpPost("persona")]
    public ActionResult<string> CrearPersona(string nombre)
    {
        var persona = new Persona { Nombre = nombre };

        return Ok(persona.Saludar());
    }

    // ✅ Crear Estudiante
    [HttpPost("estudiante")]
    public ActionResult<object> CrearEstudiante(string nombre, int edad)
    {
        var estudiante = new Estudiante();
        estudiante.Nombre = nombre;
        estudiante.SetEdad(edad);

        return Ok(new
        {
            saludo = estudiante.Saludar(),
            edad = estudiante.MostrarEdad(),
            accion = estudiante.Estudiar()
        });
    }

    // ✅ Crear Profesor
    [HttpPost("profesor")]
    public ActionResult<object> CrearProfesor(string nombre, int edad)
    {
        var profesor = new Profesor();
        profesor.Nombre = nombre;
        profesor.SetEdad(edad);

        return Ok(new
        {
            saludo = profesor.Saludar(),
            accion = profesor.Explicar()
        });
    }
}