using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    //inheriting from ViewComponent
    public class NavigationMenuViewComponent : ViewComponent
    {
        //bringing in repository
        private IBookstoreRepository repository;

        public NavigationMenuViewComponent(IBookstoreRepository r)
        {
            repository = r;
        }

        //dropping a partial view into the view
        public IViewComponentResult Invoke()
        {
            //going to the values in the route data and getting the category
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                //order by whatever is normal for that data
                .OrderBy(x => x));
        }
    }
}
