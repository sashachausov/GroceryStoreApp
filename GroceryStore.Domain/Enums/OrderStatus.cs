using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Enums
{
    public enum OrderStatus
    {
        Draft = 0, // Списан
        Confirmed = 1, // Подтвержден
        Paid = 2, // Оплачен
        Cancelled = 3, // Отменен
    }
}
