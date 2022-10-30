using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data
{
    public class MealPlanningDbContext : DbContext
    {
        public DbSet<User>? users { get; set; }
        public DbSet<Recipe>? recipes { get; set; }
        public DbSet<Household>? houses { get; set; }
        public DbSet<Group>? groups { get; set; }

        public MealPlanningDbContext(DbContextOptions<MealPlanningDbContext> options) : base(options)
        {
            
        }
    }
}
