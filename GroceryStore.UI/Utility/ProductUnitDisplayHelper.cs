using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.UI.Utility
{
    public static class ProductUnitDisplayHelper
    {
        public static string ToDisplayName(ProductUnit unit)
        {
            switch (unit)
            {
                case ProductUnit.Piece:
                    return "Штука";
                case ProductUnit.Kg:
                    return "Килограмм";
                case ProductUnit.Liter:
                    return "Литр";
                default:
                    return unit.ToString();
            }
        }

        public static List<ProductUnitComboItem> GetComboItems()
        {
            return Enum.GetValues<ProductUnit>().Select(unit => new ProductUnitComboItem
            {
                Value = unit,
                DisplayName = ToDisplayName(unit),
            }).ToList();
        }
    }

    public sealed class ProductUnitComboItem
    {
        public ProductUnit Value { get; init; }
        public string DisplayName { get; init; } = string.Empty;
    }
}
