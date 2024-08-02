namespace FunctionChefApi.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open ChefDomain.Types

[<ApiController>]
[<Route("[controller]")>]
type RecipesController(logger: ILogger<RecipesController>) =
    inherit ControllerBase()

    let stubRecipes =
        fun () ->
            [ { Name = "Kartoffelbrei"
                Ingredients =
                  [ { Name = "Kartoffeln"
                      Quantity = 1.0
                      Unit = "Kg" }
                    { Name = "Butter"
                      Quantity = 100.0
                      Unit = "g" }
                    { Name = "Milch"
                      Quantity = 200.0
                      Unit = "ml" }
                    { Name = "Salz"
                      Quantity = 1.0
                      Unit = "Prise" } ]
                Instructions =
                  [ "Kartoffeln schälen und in Salzwasser kochen"
                    "Kartoffeln abgießen und stampfen"
                    "Butter und Milch hinzufügen"
                    "Mit Salz abschmecken" ] }
              { Name = "Spaghetti Carbonara"
                Ingredients =
                  [ { Name = "Spaghetti"
                      Quantity = 500.0
                      Unit = "g" }
                    { Name = "Speck"
                      Quantity = 200.0
                      Unit = "g" }
                    { Name = "Eier"
                      Quantity = 2.0
                      Unit = "Stk" }
                    { Name = "Parmesan"
                      Quantity = 100.0
                      Unit = "g" }
                    { Name = "Salz"
                      Quantity = 1.0
                      Unit = "Prise" }
                    { Name = "Pfeffer"
                      Quantity = 1.0
                      Unit = "Prise" } ]
                Instructions =
                  [ "Spaghetti kochen"
                    "Speck anbraten"
                    "Eier, Parmesan, Salz und Pfeffer verquirlen"
                    "Spaghetti abgießen und mit Ei-Mischung vermengen"
                    "Speck darüber geben" ] }
              { Name = "Pfannkuchen"
                Ingredients =
                  [ { Name = "Mehl"
                      Quantity = 250.0
                      Unit = "g" }
                    { Name = "Milch"
                      Quantity = 500.0
                      Unit = "ml" }
                    { Name = "Eier"
                      Quantity = 3.0
                      Unit = "Stk" }
                    { Name = "Salz"
                      Quantity = 1.0
                      Unit = "Prise" } ]
                Instructions =
                  [ "Mehl, Milch, Eier und Salz verrühren"
                    "Teig 30 Minuten ruhen lassen"
                    "Pfannkuchen in einer Pfanne ausbacken" ] } ]

    [<HttpGet>]
    member _.Get() = stubRecipes ()
