using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTOs
{
    public class FoodAndDrink
    {
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string Image {  get; set; }
        public bool Available { get; set; }
        public DateTime CreateAt { get; set; }

        public FoodAndDrink(){}

        public FoodAndDrinkDTO(
            string foodId,
            string foodName,
            decimal price,
            string categoryId,
            string image,
            bool available,
            DateTime createdAt)
        {
            FoodId = foodId;
            FoodName = foodName;
            Price = price;
            CategoryId = categoryId;
            Image = image;
            Available = available;
            CreatedAt = createdAt;
        }


    }
}