namespace ContosoPizza.Models;

// The Id property is required by the database for the primary key.
// Name Property defines the name of the pizza.
// IsGlutenFree Property defines whether the pizza is gluten free or not.

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}
