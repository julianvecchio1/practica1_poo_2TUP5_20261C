namespace Web.Ej3;

public class Persona
{
    public string Nombre { get; set; }
    protected int Edad;

    public void SetEdad(int edad)
    {
        Edad = edad;
    }

    public virtual string Saludar()
    {
        return $"Hola soy {Nombre}";
    }
}