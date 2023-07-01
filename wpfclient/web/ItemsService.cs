using Microsoft.EntityFrameworkCore;
using classlib;

public class ItemsService
{
    private readonly ItemsContext _context;
    public ItemsService(ItemsContext context)
    {
        _context = context;
    }

    public IEnumerable<ToDoItems> GetAll() => _context.items.AsNoTracking().ToList();

    public ToDoItems GetItemsById(string id) => _context.items
        .AsNoTracking()
        .SingleOrDefault(i => i.ToDoItemsId == id);

    public ToDoItems AddItems(ToDoItems newItems)
    {
        _context.items.Add(newItems);
        _context.SaveChanges();
        return newItems;
    }

    public void DeleteItemsById(string id)
    {
        var Items2delete = _context.items.Find(id);
        if (Items2delete is not null)
        {
            _context.items.Remove(Items2delete);
            _context.SaveChanges();
        }
    }

}