using ErrorOr;
using MockClothesCommerceAPI.Contracts.User;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.ServiceErrors;

namespace MockClothesCommerceAPI.Services.User
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public void CreateUser(Models.User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return;
        }

        public void DeleteUser(Models.User User)
        {
            _context.Users.Remove(User);
            _context.SaveChanges();
            return;
        }

        public void DeleteUser(int id)
        {
            var userToDelete = _context.Users.Find(id);
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
            return;
        }

        public ErrorOr<Models.User> GetUser(int id)
        {
            if (_context.Users.Any(u => u.Id == id))
                return _context.Users.Where(u => u.Id == id).FirstOrDefault();

            return Errors.User.NotFound;
        }

        public ICollection<Models.User> GetUsers()
        {
            var users = _context.Users.ToList();
            Console.WriteLine($"Retrieved {users.Count} users");
            return users;
        }

        public async Task UpdateUser(int id, UpdateUserRequest updateUserRequest)
        {

            var userToUpdate = await _context.Users.FindAsync(id);
            if (updateUserRequest.Name is not null) userToUpdate.Name = updateUserRequest.Name;
            if (updateUserRequest.Email is not null) userToUpdate.Email = updateUserRequest.Email;
            if (updateUserRequest.Password is not null) userToUpdate.Password = updateUserRequest.Password;

            await _context.SaveChangesAsync();
        }
    }
}
