using MockClothesCommerceAPI.Contracts.User;
using MockClothesCommerceAPI.Data;

namespace MockClothesCommerceAPI.Services.User
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }
        /*Create a user*/
        public bool CreateUser(Models.User user)
        {
            _context.Users.Add(user);
            return Save();
        }

        /*Deletes a user*/
        public bool DeleteUser(Models.User user)
        {
            _context.Users.Remove(user);
            return Save();
        }

        /*Get a single user*/
        public Models.User GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        /*Get a list of users*/
        public ICollection<Models.User> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        /*Updates a user*/
        public bool UpdateUser(int userId, UpdateUserRequest userUpdated)
        {
            var existingUser = _context.Users.Find(userId);

            if (userUpdated.Name is not null) existingUser.Name = userUpdated.Name;
            if (userUpdated.Email is not null) existingUser.Name = userUpdated.Email;
            if (userUpdated.Password is not null) existingUser.Name = userUpdated.Password;

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }

    }
}
