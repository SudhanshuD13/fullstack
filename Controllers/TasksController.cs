using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Data;
using TaskManagerApp.Models;

namespace TaskManagerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase {
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context) {
        _context = context;
    }

    // 1. GET: api/Tasks (Saare tasks dekhne ke liye)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoTask>>> GetTasks() {
        return await _context.Tasks.ToListAsync();
    }

    // 2. POST: api/Tasks (Naya task add karne ke liye)
    [HttpPost]
    public async Task<ActionResult<TodoTask>> PostTask(TodoTask task) {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
    }
}
