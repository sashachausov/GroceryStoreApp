using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Other
{
    public enum ProductSortOption
    {
        Default,
        Alphabetical,
        PriceAscending,
        PriceDescending,
    }

    public class ProductQuery
    {
        public string? Name { get; set; }
        public decimal? MaxPrice { get; set; }

        public ProductSortOption SortOption { get; set; } = ProductSortOption.Default;
    }
}
