using Microsoft.AspNetCore.Mvc;
using classlib;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    ItemsService _service;

    public ItemsController(ItemsService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<ToDoItems> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}/getitem")]
    public ActionResult<ToDoItems> GetById(string id)
    {
        var item = _service.GetItemsById(id);

        if (item is not null)
        {
            return item;
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost("AddItems")]
    public IActionResult Create(ToDoItems newStudent)
    {
        var item = _service.AddItems(newStudent);
        return CreatedAtAction(nameof(GetById), new { id = item!.ToDoItemsId }, item);
    }

    [HttpDelete("deleteitem/{id}")]
    public IActionResult Delete(string id)
    {
        var item = _service.GetItemsById(id);
        if (item is not null)
        {
            _service.DeleteItemsById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}