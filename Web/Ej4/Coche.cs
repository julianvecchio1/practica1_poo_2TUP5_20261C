namespace Web.Ej4;

public class Coche : IVehiculo
{
    private int combustible;

    // Constructor
    public Coche(int combustibleInicial)
    {
        combustible = combustibleInicial;
    }

    public string Conducir()
    {
        if (combustible > 0)
            return "El coche está siendo manejado";
        else
            return "El coche no tiene combustible";
    }

    public bool CargarCombustible(int cantidad)
    {
        combustible += cantidad;
        return true;
    }
}