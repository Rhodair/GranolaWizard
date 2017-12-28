using GranolaWizard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql

namespace GranolaWizard.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Seed if none exist
                if (!context.Items.Any())
                {
                    context.Items.AddRange(
                        new TodoItem
                        {
                            Id = Guid.NewGuid(),
                            IsDone = false,
                            Title = "Learn ASP.NET Core",
                            DueAt = DateTimeOffset.Now.AddDays(1)
                        },

                        new TodoItem
                        {
                            Id = Guid.NewGuid(),
                            IsDone = false,
                            Title = "Build awesome apps",
                            DueAt = DateTimeOffset.Now.AddDays(2)
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
