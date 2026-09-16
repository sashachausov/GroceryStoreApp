using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Mappers.Categories
{
    public sealed class CategoryEditDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; } = "";
        
        /// <summary>
        /// Relative image path.
        /// Null means default image.
        /// </summary>
        public string? RelativeImagePath { get; set; }
    }
}
