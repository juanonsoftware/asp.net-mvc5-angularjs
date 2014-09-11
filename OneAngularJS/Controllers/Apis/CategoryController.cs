using OneAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace OneAngularJS.Controllers.Apis
{
    public class CategoryController : ApiController
    {
        private static IList<CategoryViewModel> _allCategories;

        public CategoryController()
        {
            TryInitCategories();
        }

        private void TryInitCategories()
        {
            if (_allCategories == null)
            {
                _allCategories = new List<CategoryViewModel>();
            }
        }

        public IEnumerable<CategoryViewModel> Get()
        {
            return Get(string.Empty);
        }

        public IEnumerable<CategoryViewModel> Get(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return _allCategories;
            }
            return _allCategories.Where(c => c.Name.Contains(query) || c.Description.Contains(query));
        }

        /// <summary>
        /// Create
        /// </summary>
        public void Post(CategoryViewModel model)
        {
            _allCategories.Add(model);
        }

        /// <summary>
        /// Update
        /// </summary>
        public void Put(CategoryViewModel model)
        {
            var existingCategory = _allCategories.First(x => x.Id == model.Id);
            _allCategories.Remove(existingCategory);

            _allCategories.Add(model);
        }

        public void Delete(Guid id)
        {
            var existingCategory = _allCategories.FirstOrDefault(x => x.Id == id);
            if (existingCategory != null)
            {
                _allCategories.Remove(existingCategory);
            }
        }
    }
}