using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GameStoreEntities : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<GameStore.Models.Platform> Platforms { get; set; }

        public System.Data.Entity.DbSet<GameStore.Models.Studio> Studios { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<GameStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}