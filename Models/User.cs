namespace MealPlanningAPI.Models
{
    public class User
    {
        public int UserID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User (int userID, string firstName, string lastName, string email)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
