using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    // our list of pizza objects - we will use this as our "database" for now
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;

    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Classic Italian",
                IsGlutenFree = false
            },
            new Pizza
            {
                Id = 2,
                Name = "Veggie",
                IsGlutenFree = true
            }
        };
    }

    // get all pizzas
    public static List<Pizza> GetAll() => Pizzas;

    // get a pizza by id
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    // add a pizza
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    // delete a pizza
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    // update a pizza
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
}
