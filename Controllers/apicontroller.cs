using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    private readonly ApisDbC _context;

    public ApiController(ApisDbC context)
    {
        _context = context;
    }

    // GET: api/api
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Api>>> GetTodos()
    {
        return await _context.Apis.ToListAsync();
    }

    // GET: api/api/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Api>> GetTodo(int id)
    {
        var api = await _context.Apis.FindAsync(id);
        if (api == null)
        {
            return NotFound();
        }
        return api;
    }

    // POST: api/api
    [HttpPost]
    public async Task<ActionResult<Api>> PostTodo(Api api)
    {
        _context.Apis.Add(api);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTodo), new { id = api.id }, api);
    }

    // PUT: api/api/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodo(int id, Api api)
    {
        if (id != api.id)
        {
            return BadRequest();
        }

        _context.Entry(api).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TodoExists(id))
            {
                return NotFound();
            }
            throw;
        }

        return NoContent();
    }

    // DELETE: api/api/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(int id)
    {
        var api = await _context.Apis.FindAsync(id);
        if (api == null)
        {
            return NotFound();
        }

        _context.Apis.Remove(api);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TodoExists(int id)
    {
        return _context.Apis.Any(e => e.id == id);
    }
}
