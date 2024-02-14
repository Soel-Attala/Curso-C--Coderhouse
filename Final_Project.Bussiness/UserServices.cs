using Final_Project.Data;
using Final_Project.Entity;

namespace Final_Project.Bussiness
{
    public static class UserServices
    {
        public static List<User> GetAllUsers()
        {
            DatabaseManager databaseManager = new DatabaseManager();
            // Assume DatabaseManager has a method GetAllUsers() in the Data Access Layer
            return databaseManager.GetUserById();
        }

        // Add other business logic methods related to User entity if needed
    }
}