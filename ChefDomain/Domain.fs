namespace ChefDomain

module Types =
    type Ingredient = {
        Name: string
        Quantity: float
        Unit: string
    }

    type Recipe = {
        Name: string
        Ingredients: Ingredient list
        Instructions: string list
    }
