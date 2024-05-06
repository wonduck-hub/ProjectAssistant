using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceUserModel
{
    public interface IWorkspaceUserRepository
    {
        Task<WorkspaceUser> AddWorkspaceUserAsync(WorkspaceUser r);
        Task<List<WorkspaceUser>> GetUsersByWorkspaceId(int workspaceId);
        Task<List<WorkspaceUser>> GetWorkspacesByUserId(string userId);
        Task<List<WorkspaceUser>> GetWorkspaceUserByUserIdAsync(string userId);
        Task<List<WorkspaceUser>> GetWorkspaceUserByWorkspaceIdAsync(int id);
        Task<WorkspaceUser> UpdateWorkspaceUserAsync(WorkspaceUser r);
        Task RemoveWorkspaceUserAsync(string userId, int workspaceId);
    }
}
