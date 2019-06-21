using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStoreApp.Models
{
    public partial class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Game> Games { get; set; }
    }
}