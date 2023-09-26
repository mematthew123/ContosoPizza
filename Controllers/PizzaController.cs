using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController() { }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    // POST action
    // This code will save the pizza and return a result of 200-OK if successful.
    [HttpPost]
    public IActionResult Create(Pizza pizza) { }

    // PUT action
    // This code will update the pizza and return a result of 200-OK if successful.
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza) { }

    // DELETE action
    // This code will delete the pizza and return a result of 200-OK if successful.
    [HttpDelete("{id}")]
    public IActionResult Delete(int id) { }
}
