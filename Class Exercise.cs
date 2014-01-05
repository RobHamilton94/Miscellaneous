using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    

    class Dish
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }

        public List<Ingredient> Ingredients = new List<Ingredient>();


        public virtual decimal Total()
        {

            decimal total = 0m;

            foreach (var Ingredient in Ingredients)
            {
                total += Ingredient.Price;
            }

            total += BasePrice;

            return total;
        }
    }

    class Pasta : Dish
    {
        private decimal IngredientDiscount = .75m;
        public override decimal Total()
        {
            decimal total = 0m;
            foreach (var Ingredient in Ingredients)
            {
                total += (Ingredient.Price * IngredientDiscount);
            }

            total += BasePrice;

            return base.Total();
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Pizza : Dish
    {
        
    }

    class Order
    {
        public List<Dish> ListItems = new List<Dish>();

        private decimal TaxRate = 0.7m;

        public string CustomerName { get; set; }
        public string ClerkName { get; set; }
        public decimal Gratuity = 0m; // We don't know this until after the customer pays the bill

        public decimal SubTotal()
        {
            decimal subtotal = 0m;
            foreach (var dish in ListItems)
            {
                subtotal += dish.Total();
            }
            return subtotal;
        }

        public decimal Tax
        {
            get { return SubTotal() * TaxRate; }
        }

        public decimal GrandTotal()
        {

            return SubTotal() + Tax;
        }
    }
}

