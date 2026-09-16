using GroceryStore.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Infrastructure.Persistence.Json
{
    public class JsonUnitOfWork : IUnitOfWork
    {
        public Task SaveChangesAsync() => Task.CompletedTask;
    }
}
