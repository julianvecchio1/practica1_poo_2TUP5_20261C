using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albums = new List<PhotoBook>();
    private static int nextId = 1;

    // ✅ POST → crear álbum estándar
    [HttpPost("standard")]
    public ActionResult<PhotoBook> CrearAlbum(int? paginas)
    {
        PhotoBook album;

        if (paginas.HasValue)
            album = new PhotoBook(paginas.Value);
        else
            album = new PhotoBook();

        album.Id = nextId++;
        albums.Add(album);

        return Ok(album);
    }

    // ✅ POST → crear álbum grande (64 páginas)
    [HttpPost("big")]
    public ActionResult<PhotoBook> CrearAlbumGrande()
    {
        var album = new BigPhotoBook();

        album.Id = nextId++;
        albums.Add(album);

        return Ok(album);
    }

    // ✅ GET → obtener páginas por ID
    [HttpGet("{id}")]
    public ActionResult<int> GetPaginas(int id)
    {
        var album = albums.FirstOrDefault(a => a.Id == id);

        if (album == null)
            return NotFound("Álbum no encontrado");

        return Ok(album.GetNumberPages());
    }

    // ✅ GET → todos los álbumes
    [HttpGet]
    public ActionResult<List<PhotoBook>> GetAll()
    {
        return Ok(albums);
    }
}