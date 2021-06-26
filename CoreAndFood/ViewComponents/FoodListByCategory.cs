using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id )
        {
            
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.List(x=>x.CategoryID==id);
            return View(foodList);
        }
    }
}
