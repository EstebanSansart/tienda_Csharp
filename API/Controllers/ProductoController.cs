using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
public class ProductoController : BaseApiController
{
    private readonly TiendaContext _context;
    public ProductoController(TiendaContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Producto>>> Get()
    {
        var nameVar = await _context.Productos.ToListAsync();
        return Ok(nameVar);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Get(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        return Ok(producto);
    }

}
