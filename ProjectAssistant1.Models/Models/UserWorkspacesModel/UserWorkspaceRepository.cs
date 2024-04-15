using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectAssistant1.Models.UserWorkspacesModel
{
    public class UserWorkspaceRepository : IUserWorkspaceRepositoryAsync
    {
        private readonly ProjectAssistantDbContext _context;

        public UserWorkspaceRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<UserWorkspace> AddUserWorkspaceAsync(UserWorkspace r)
        {
            _context.UserWorkspaces.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }

        public Task<List<UserWorkspace>> GetUserWorkspacesByUserIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserWorkspace>> GetUserWorkspacesByWorkspaceIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveUserWorkspaceAsync(string userId, int workspaceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserWorkspace> UpdateUserWorkspaceAsync(UserWorkspace r)
        {
            throw new System.NotImplementedException();
        }
    }
}
