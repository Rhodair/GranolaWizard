using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GranolaWizard.Models;
using GranolaWizard.Services;
using GranolaWizard.ViewModels;

namespace GranolaWizard.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            // Get to-do items from database
            var todoItems = await _todoItemService.GetIncompleteItemsAsync();
            // Put items in view-model
            var model = new TodoViewModel()
            {
                Items = todoItems
            };
            // Pass model to view and render
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
