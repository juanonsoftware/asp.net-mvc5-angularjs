using System;
using System.Linq;
using System.Web.Mvc;
using OneAngularJS.Models;
using System.Collections.Generic;
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
            return _allCategories;
        }

        /// <summary>
        /// Create
        /// </summary>
        public ActionResult Post(CategoryViewModel model)
        {
            _allCategories.Add(model);
            return new EmptyResult();
        }

        /// <summary>
        /// Update
        /// </summary>
        public ActionResult Put(CategoryViewModel model)
        {
            var existingCategory = _allCategories.First(x => x.Id == model.Id);
            _allCategories.Remove(existingCategory);

            _allCategories.Add(model);

            return new EmptyResult();
        }

        public ActionResult Delete(Guid id)
        {
            var existingCategory = _allCategories.First(x => x.Id == id);
            _allCategories.Remove(existingCategory);

            return new EmptyResult();
        }
    }
}