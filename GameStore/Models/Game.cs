using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Models
{
    [Bind(Exclude = "GameId")]
    public class Game
    {
        [ScaffoldColumn(false)]
        public int GameId { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        [DisplayName("Studio")]
        public int StudioId { get; set; }
        [DisplayName("Platform")]
        public int PlatformId { get; set; }
        [Required(ErrorMessage = "Game Title is required")]
        [StringLength(100)]
        public string Title { get; set; }
        [DisplayName("Language")]
        [StringLength(50)]
        public string Language { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01,300.00, ErrorMessage = "Price beetwen 0.01 - 300.00")]
        public decimal Price { get; set; }
        [DisplayName("Game Picture URL")]
        [StringLength(1024)]
        public string GamePicture { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(8, 18, ErrorMessage = "Age beetwen 8 - 18")]
        public int Age { get; set; }
        public virtual Platform Platform { get; set;} 
        public virtual Genre Genre { get; set; }
        public virtual Studio Studio { get; set; }

    }
}