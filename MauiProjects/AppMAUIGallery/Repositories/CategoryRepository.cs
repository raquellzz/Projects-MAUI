﻿using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Repositories
{
    class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category {
                Name = "Layout",
                Components = new List<Component> { new Component { Title = "StackLayout", Description = "The StackLayout is a layout that arranges its children into a single line that can be oriented horizontally or vertically.", Page = new StackLayoutPage() } }
            } );

            return categories;
        }
    }
}
