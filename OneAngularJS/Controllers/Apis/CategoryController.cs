using OneAngularJS.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace OneAngularJS.Controllers.Apis
{
    public class CategoryController : ApiController
    {
        public IEnumerable<CategoryViewModel> Get()
        {
            return new List<CategoryViewModel>()
                   {
                       new CategoryViewModel()
                       {
                           Name = "Slr",
                           Description = "Salary",
                           HasRecords = true
                       },
                       new CategoryViewModel()
                       {
                           Name = "Out",
                           Description = "Out",
                           HasRecords = false
                       }
                   };
        }
    }
}