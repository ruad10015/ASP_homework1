using homework1.Entities;
using homework1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace homework1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(GetAllData());
        }
        public IActionResult Drinks()
        {
            return View(AllDrinks());
        }
        public IActionResult FastFoods()
        {
            return View(AllFastFoods());
        }
        public IActionResult HotMeals()
        {
            return View(AllHotMeals());
        }
        public List<Drink> AllDrinks() 
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink
            {
                Id = 1,
                Name = "Coca-Cola",
                Description = "This is the coca cola",
                Price = 2,
            },
             new Drink
            {
                Id = 2,
                Name = "Fanta",
                Description = "This is the fanta",
                Price = 2,
            },
              new Drink
            {
                Id = 3,
                Name = "Coffee",
                Description = "This is the coffee",
                Price = 0.8,
            },
               new Drink
            {
                Id = 4,
                Name = "Milkshake",
                Description = "This is the Milkshake",
                Price = 4.5,
            },
                new Drink
            {
                Id = 5,
                Name = "Sprite",
                Description = "This is the Sprite ",
                Price = 2,
            }
            };

            return drinks;
        }

        public List<FastFood> AllFastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>()
            {
            new FastFood
            {
                Id = 1,
                Name = "Cheeseburger",
                Description = "Juicy beef patty with melted cheese, lettuce, tomato, and pickles.",
                Price = 5.99,
            },
            new FastFood
            {
                Id = 2,
                Name = "Chicken Nuggets",
                Description = "Crispy breaded chicken nuggets served with your choice of dipping sauce.",
                Price = 4.49,
            },
            new FastFood
            {
                Id = 3,
                Name = "Fries",
                Description = "Crispy fries seasoned with salt.",
                Price = 2.99,
            },
            new FastFood
            {
                Id = 4,
                Name = "Döner",
                Description = "A döner is a Turkish dish of rotisserie-cooked meat, often served in bread.",
                Price = 3.49,
            },
            new FastFood
            {
                Id = 5,
                Name = "Hot Dog",
                Description = "A classic hot dog served in a bun with mustard and ketchup.",
                Price = 3.29,
            }

            };

            return fastFoods;
        }

        public List<HotMeal> AllHotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
            new HotMeal
            {
                Id = 1,
                Name = "Pizza Margaritta",
                Description = "Classic Italian Margaritta pizza with cheese and pomidor.",
                Price = 10.99
            },
            new HotMeal
            {
                Id = 2,
                Name = "Pizza Pepperoni",
                Description = "Classic Italian Pepperoni pizza with cheese ,sousage and pomidor.",
                Price = 12.99
            },
            new HotMeal
            {
                Id = 3,
                Name = "Pizza 4 cheese",
                Description = "Classic Italian Margaritta pizza with 4 different cheeses",
                Price = 13.49
            }
            };

            return hotMeals;
        }
        public AllFoodsViewModel GetAllData()
        {
            var allFoods = new AllFoodsViewModel(AllDrinks(), AllFastFoods(), AllHotMeals());
            return allFoods;
        }

    }
}
