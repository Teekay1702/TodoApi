using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

public class TodoModel : PageModel
{
    private readonly TodoContext _context;

    public TodoModel(TodoContext context)
    {
        _context = context;
    }

    [BindProperty]
    public TodoItem NewTodo { get; set; } = new();

    public List<TodoItem> Todos { get; set; } = new();

    public async Task OnGetAsync()
    {
        Todos = await _context.TodoItems.ToListAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!string.IsNullOrWhiteSpace(NewTodo.Name))
        {
            var todo = new TodoItem
            {
                Name = NewTodo.Name,
                IsComplete = false
            };
            _context.TodoItems.Add(todo);
            await _context.SaveChangesAsync();
        }

        Todos = await _context.TodoItems.ToListAsync();
        return Page();
    }



    public async Task<IActionResult> OnPostToggleAsync(long id)
    {
        var item = await _context.TodoItems.FindAsync(id);
        if (item != null)
        {
            item.IsComplete = !item.IsComplete;
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(long id)
    {
        var item = await _context.TodoItems.FindAsync(id);
        if (item != null)
        {
            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}
