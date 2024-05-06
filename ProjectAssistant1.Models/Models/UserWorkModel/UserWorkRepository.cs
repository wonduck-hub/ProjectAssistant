using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.UserWorkModel
{
    public class UserWorkRepository : IUserWorkRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public UserWorkRepository(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task<UserWork> AddUserWorkAsync(UserWork newUserWork)
        {
            Debug.Assert(newUserWork != null, "workList is null");

            _context.UserWork.Add(newUserWork);
            await _context.SaveChangesAsync();

            return newUserWork;
        }

        public Task<List<UserWork>> GetUserWorkByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserWork>> GetUserWorkByWorkspaceIdAsync()
        {
            throw new NotImplementedException();
        }

        public Work RemoveUserWorkAsync(string userId, int listId)
        {
            throw new NotImplementedException();
        }

        public Task<UserWork> UpdateUserWorkAsync(UserWork r)
        {
            throw new NotImplementedException();
        }
    }
}
