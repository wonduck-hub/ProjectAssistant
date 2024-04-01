using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.UserWorkspacesModel
{
    public interface IUserWorkspaceRepositoryAsync
    {
        Task<UserWorkspace> AddUserWorkspaceAsync(UserWorkspace r);
        Task<List<UserWorkspace>> GetUserWorkspacesByUserIdAsync();
        Task<List<UserWorkspace>> GetUserWorkspacesByWorkspaceIdAsync();
        Task<UserWorkspace> UpdateUserWorkspaceAsync(UserWorkspace r);
        Task RemoveUserWorkspaceAsync(string userId, int workspaceId);
    }
}
