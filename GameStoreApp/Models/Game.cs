using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GameStoreApp.Models
{
    [Bind(Exclude = "GameID")]
    public class Game
    {
        [ScaffoldColumn(false)]
        public int GameID { get; set; }
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [StringLength(160)]
        public string Title { get; set; }
        [Range(0.01, 400.00, ErrorMessage = "Cena musi być między 0.01 a 400.00")]
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
    }
}