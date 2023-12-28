using ATM.Models;

namespace ATM.Service
{
    public class UserService
    {
        private readonly AtmDbContext _context;

        public UserService(AtmDbContext context)
        {
            _context = context;
        }

        public int Save(UserModel user)
        {
            _context.User.Add(user);
            _context.SaveChanges();

            return user.Id;
        }
    }
}
