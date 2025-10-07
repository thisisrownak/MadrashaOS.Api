namespace MadrashaOS.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Later use hashing
        public string Role { get; set; } // "Student", "Teacher", "Admin"
    }
}
