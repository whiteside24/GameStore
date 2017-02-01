using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameStore.Models;

namespace GameStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<GameStoreEntities>
    {
        protected override void Seed(GameStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "RPG" },
                new Genre { Name = "FPS" },
                new Genre { Name = "TPP" },
                new Genre { Name = "Strategy" },
                new Genre { Name = "Simulation" },
                new Genre { Name = "Sport" },
                new Genre { Name = "Action" },
                new Genre { Name = "Adventure" }
            };

            var studios = new List<Studio>
            {
                new Studio { Name = "Nintendo" },
                new Studio { Name = "Rockstar" },
                new Studio { Name = "Valve" },
                new Studio { Name = "Ubisoft" },
                new Studio { Name = "Electronic Arts" },
                new Studio { Name = "Bethesda" },
                new Studio { Name = "Sony" },
                new Studio { Name = "Microsoft" },
                new Studio { Name = "Activision Blizzard" },
                new Studio { Name = "2K" }
            };
            var platforms = new List<Platform>
            {
                new Platform { Name = "Playstation 4" },
                new Platform { Name = "Playstation 3" },
                new Platform { Name = "Xbox 360" },
                new Platform { Name = "Xbox One" },
                new Platform { Name = "PC" },
                new Platform { Name = "Nintendo Wii U" }
                
            };

            new List<Game>
            {
                new Game { Title = "FIFA 17", Genre = genres.Single(g => g.Name == "Sport"), Platform = platforms.Single(p => p.Name == "Playstation 4"), Price = 150.99M, Language = "Polish", Age = 8, Studio = studios.Single(a => a.Name == "Electronic Arts"), GamePicture = "/Content/Images/gamePicture.jpg" },
                new Game { Title = "Skyrim", Genre = genres.Single(g => g.Name == "RPG"), Platform = platforms.Single(p => p.Name == "PC"), Price = 110.99M, Language = "Polish", Age = 16, Studio = studios.Single(a => a.Name == "Bethesda"), GamePicture = "/Content/Images/gamePicture.jpg" },
                new Game { Title = "NBA 2k17", Genre = genres.Single(g => g.Name == "Sport"), Platform = platforms.Single(p => p.Name == "Xbox One"), Price = 200.99M, Language = "Polish", Age = 8, Studio = studios.Single(a => a.Name == "2K"), GamePicture = "/Content/Images/gamePicture.jpg" },
                new Game { Title = "Uncharted 4", Genre = genres.Single(g => g.Name == "Action"), Platform = platforms.Single(p => p.Name == "Playstation 4"), Price = 210.99M, Language = "English", Age = 12, Studio = studios.Single(a => a.Name == "Sony"), GamePicture = "/Content/Images/gamePicture.jpg" },
                new Game { Title = "Call of Duty: Modern Warfare", Genre = genres.Single(g => g.Name == "FPS"), Platform = platforms.Single(p => p.Name == "PC"), Price = 189.99M, Language = "Polish", Age = 18, Studio = studios.Single(a => a.Name == "Activision Blizzard"), GamePicture = "/Content/Images/gamePicture.jpg" },

            }.ForEach(a => context.Games.Add(a));
        }
    }
}