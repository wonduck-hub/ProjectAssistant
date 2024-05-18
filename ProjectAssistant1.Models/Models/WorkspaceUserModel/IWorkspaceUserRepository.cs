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
        Task<WorkspaceUser> GetWorkspaceUserByWorkspaceIdUserId(string userId, int workspaceId);
        Task<List<WorkspaceUser>> GetWorkspaceUserByWorkspaceId(int workspaceId);
        Task<List<WorkspaceUser>> GetWorkspaceUserByUserId(string userId);
        Task<WorkspaceUser> UpdateWorkspaceUserAsync(WorkspaceUser r);
        Task RemoveWorkspaceUserAsync(string userId, int workspaceId);
    }
}
