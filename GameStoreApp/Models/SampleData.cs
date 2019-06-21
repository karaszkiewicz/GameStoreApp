using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameStoreApp.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<GameStoreEntities>
    {
        protected override void Seed(GameStoreEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Akcja" },
                new Category { Name = "Przygodowa" },
                new Category { Name = "Symulacyjna" },
                new Category { Name = "Strategia" },
                new Category { Name = "Sportowa" }
            };

            new List<Game>
            {
                new Game {Title = "Grand Theft Auto 5", Category = categories.Single(g => g.Name == "Akcja"), Price = 120.00M},
                new Game {Title = "Cyberpunk 2077", Category = categories.Single(g => g.Name == "Akcja"), Price = 199.99M},
                new Game {Title = "Mortal Kombat XL", Category = categories.Single(g => g.Name == "Akcja"), Price = 107.99M},
                new Game {Title = "Tom Clancy's Rainbow Six® Siege", Category = categories.Single(g => g.Name == "Akcja"), Price = 79.90M},
                new Game {Title = "ARK: Survival Evolved", Category = categories.Single(g => g.Name == "Przygodowa"), Price = 63.00M},
                new Game {Title = "The Forest", Category = categories.Single(g => g.Name == "Przygodowa"), Price = 32.99M},
                new Game {Title = "Hurtworld", Category = categories.Single(g => g.Name == "Przygodowa"), Price = 25.00M},
                new Game {Title = "Next Day: Survival", Category = categories.Single(g => g.Name == "Przygodowa"), Price = 7.20M},
                new Game {Title = "Farming Simulator 19", Category = categories.Single(g => g.Name == "Symulacyjna"), Price = 129.99M},
                new Game {Title = "Scrap Mechanic", Category = categories.Single(g => g.Name == "Symulacyjna"), Price = 54.22M},
                new Game {Title = "Cities: Skylines", Category = categories.Single(g => g.Name == "Symulacyjna"), Price = 120.86M},
                new Game {Title = "theHunter: Call of the Wild™", Category = categories.Single(g => g.Name == "Symulacyjna"), Price = 54.55M},
                new Game {Title = "Sid Meier’s Civilization® VI", Category = categories.Single(g => g.Name == "Strategia"), Price = 26.65M},
                new Game {Title = "Total War: THREE KINGDOMS", Category = categories.Single(g => g.Name == "Strategia"), Price = 19.99M},
                new Game {Title = "Rocket League®", Category = categories.Single(g => g.Name == "Sportowa"), Price = 15.00M},
                new Game {Title = "Football Manager 2019", Category = categories.Single(g => g.Name == "Sportowa"), Price = 130.99M},
                new Game {Title = "F1® 2019 Anniversary Edition", Category = categories.Single(g => g.Name == "Sportowa"), Price = 159.00M},
                new Game {Title = "Euro Fishing", Category = categories.Single(g => g.Name == "Sportowa"), Price = 39.99M}
            }.ForEach(a => context.Games.Add(a));

            //base.Seed(context);
        }
    }
}