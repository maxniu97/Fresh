using Fresh.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fresh.ViewModels
{
    public class firstVM
    {
        public List<CarouselItemModel> Carousels { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public firstVM()
        {
            Carousels = new List<CarouselItemModel>();
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner1.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner2.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner3.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner4.jpg" });

            Categories = new List<ProductCategory>();
            Categories.Add(new ProductCategory { ImageName = "bread.JPG", Header = "Bread" });
            Categories.Add(new ProductCategory { ImageName = "canned.jpg", Header = "Canned Food" });
            Categories.Add(new ProductCategory { ImageName = "deli.jpg", Header = "Deli" });
            Categories.Add(new ProductCategory { ImageName = "drinks.jpg", Header = "Soft Drinks" });
            Categories.Add(new ProductCategory { ImageName = "fruit.jpg", Header = "Fruits" });
            Categories.Add(new ProductCategory { ImageName = "meat.jpeg", Header = "Meat" });
            Categories.Add(new ProductCategory { ImageName = "seafood.jpg", Header = "Seafood" });
            Categories.Add(new ProductCategory { ImageName = "seasoning.jpg", Header = "Spices" });
            Categories.Add(new ProductCategory { ImageName = "snacks.jpg", Header = "Snacks" });
            Categories.Add(new ProductCategory { ImageName = "vegetable.jpg", Header = "Vegetables" });
        }
    }
}
