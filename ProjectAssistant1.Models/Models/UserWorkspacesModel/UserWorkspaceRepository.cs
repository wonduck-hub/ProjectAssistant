using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.UserWorkspacesModel
{
    public class UserWorkspaceRepository : IUserWorkspaceRepositoryAsync
    {
        private readonly ProjectAssistantDbContext _context;

        public UserWorkspaceRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public Task<UserWorkspace> AddUserWorkspaceAsync(UserWorkspace r)
        {
            throw new System.NotImplementedException();
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
