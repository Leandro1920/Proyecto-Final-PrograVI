using System;
using System.Collections.Generic;
using System.Text;

namespace PrograVI_Final_Project.Models
{
    public class ProductByCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string detail { get; set; }
        public int categoryId { get; set; }
        public string imageUrl { get; set; }

       // public string FullImageUrl => AppSettings.ApiUrl + imageUrl;
    }
}
