[ApiController]
[Route("clientes")]
public class ClientesController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("sp")]
    public async Task<IActionResult> GetClientesViaSP(int pageNumber, int pageSize)
    {
        var clientes = await _context.Clientes
            .FromSqlRaw("EXEC sp_GetClientesPaginados @p0, @p1", pageNumber, pageSize)
            .ToListAsync();
        return Ok(clientes);
    }

    [HttpGet("ef")]
    public async Task<IActionResult> GetClientesViaEF(int pageNumber, int pageSize)
    {
        var clientes = await _context.Clientes
            .OrderBy(c => c.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return Ok(clientes);
    }
}