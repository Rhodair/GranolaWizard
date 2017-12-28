using GranolaWizard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync(ApplicationUser user)
        {
            // Return an array of TodoItems
            IEnumerable<TodoItem> items = new[]
            {
                new TodoItem
                {
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new TodoItem
                {
                    Title = "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }
            };

            return Task.FromResult(items);
        }
        
        public async Task<bool> AddItemAsync(TodoItem newItem, ApplicationUser user)
        {
            return await Task.FromResult(true);
        }
        
        public async Task<bool> MarkDoneAsync(Guid id, ApplicationUser user)
        {
            return await Task.FromResult(true);
        }
    }
}
