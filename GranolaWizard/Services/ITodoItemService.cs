using GranolaWizard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync();
    }
}
