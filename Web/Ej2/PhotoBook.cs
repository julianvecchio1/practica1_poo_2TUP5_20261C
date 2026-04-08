namespace Web.Ej2;

public class PhotoBook
{
    public int Id { get; set; }
    protected int numPages;

    // Constructor por defecto → 16 páginas
    public PhotoBook()
    {
        numPages = 16;
    }

    // Constructor con parámetro
    public PhotoBook(int pages)
    {
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}