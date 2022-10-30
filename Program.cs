using MealPlanningAPI.Data;
using MealPlanningAPI.Data.Groups;
using MealPlanningAPI.Data.Households;
using MealPlanningAPI.Data.Recipes;
using MealPlanningAPI.Data.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContexts
builder.Services.AddDbContextPool<MealPlanningDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MealPlanningDbConnect")));
builder.Services.AddScoped<IUserData, UserData>();
builder.Services.AddScoped<IRecipeData, RecipeData>();
builder.Services.AddScoped<IHouseholdData, HouseholdData>();
builder.Services.AddScoped<IGroupData, GroupData>();

// Creating a CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", b => b.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();