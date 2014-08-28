using System;

namespace OneAngularJS.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasRecords { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}