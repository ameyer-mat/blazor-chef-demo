using static ChefDomain.Types;

namespace ChefApi;

public static class StubRecipes
{
    public static List<Recipe> Recipes =
    [
        new Recipe("Kartoffelbrei",
            new List<Ingredient>
            {
                new("Kartoffeln", 1.0, "kg"), new("Butter", 100.0, "g"),
                new("Milch", 200.0, "ml"), new("Salz", 1.0, "Prise")
            }.ToFSharpList(),
            new List<string> { "Kartoffeln kochen", "Kartoffeln stampfen", "Verrühren" }.ToFSharpList()),

        new Recipe("Spaghetti Carbonara", new List<Ingredient>
            {
                new("Spaghetti", 500.0, "g"), new("Eier", 2.0, "Stück"),
                new("Speck", 100.0, "g"), new("Parmesan", 50.0, "g")
            }.ToFSharpList(),
            new List<string> { "Spaghetti kochen", "Speck anbraten", "Eier und Parmesan verrühren" }.ToFSharpList()),

        new Recipe("Pfannkuchen", new List<Ingredient>
            {
                new("Mehl", 250.0, "g"), new("Milch", 500.0, "ml"),
                new("Eier", 3.0, "Stück"), new("Salz", 1.0, "Prise"),
                new("Zucker", 1.0, "EL")
            }.ToFSharpList(),
            new List<string> { "Mehl, Milch, Eier, Salz und Zucker verrühren", "In Pfanne ausbacken" }.ToFSharpList())
    ];
}