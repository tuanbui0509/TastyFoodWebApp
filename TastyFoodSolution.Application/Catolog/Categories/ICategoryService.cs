﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Categories;

namespace TastyFoodSolution.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}