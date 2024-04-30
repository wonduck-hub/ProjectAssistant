using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ProjectAssistant1.Models.UserModel
{
    public class UserRepository : IUserRepositoryAsync
    {
        private readonly ProjectAssistantDbContext _context;

        public UserRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<User> AddUserAsync(User user)
        {
            Debug.Assert(user != null, "user is null");

            _context.AspNetUsers.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _context.AspNetUsers.FindAsync(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.AspNetUsers.ToListAsync();
        }

        public async Task<User> GetFirstUserByName(string name)
        {
            return await _context.AspNetUsers.FirstOrDefaultAsync(user => user.UserName == name);
        }

        public async Task RemoveUserAsync(string id)
        {
            var user = await _context.Workspaces.FindAsync(id);
            if (user != null)
            {
                _context.Workspaces.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
