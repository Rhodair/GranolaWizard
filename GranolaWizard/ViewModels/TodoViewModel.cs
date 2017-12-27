using GranolaWizard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.ViewModels
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}
