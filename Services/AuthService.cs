using MadrashaOS.Api.Data;
using MadrashaOS.Api.Models;

namespace MadrashaOS.Api.Services
{
    public class AuthService
    {
        private readonly MadrashaDbContext _context;
        public AuthService(MadrashaDbContext context)
        {
            _context = context;
        }

        public User? Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u =>
                u.Username == username && u.PasswordHash == password);
        }
    }
}
