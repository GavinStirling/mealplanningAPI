using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data
{
    public class MealPlanningDbContext : DbContext
    {
        public MealPlanningDbContext()
        {

        }

        public MealPlanningDbContext(DbContextOptions<MealPlanningDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
