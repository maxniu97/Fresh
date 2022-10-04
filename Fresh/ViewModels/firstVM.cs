using Fresh.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fresh.ViewModels
{
    public class firstVM
    {
        public List<CarouselItemModel> Carousels { get; set; }
        public firstVM()
        {
            Carousels = new List<CarouselItemModel>();
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner1.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner2.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner3.jpg" });
            Carousels.Add(new CarouselItemModel { ImageName = "homeBanner4.jpg" });
        }
    }
}
