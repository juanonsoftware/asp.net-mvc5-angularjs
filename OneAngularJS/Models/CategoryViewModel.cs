using System;

namespace OneAngularJS.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasRecords { get; set; }
    }
}