using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.WorkspaceModel
{
    public interface IWorkspaceRepositoryAsync
    {
        Task<Workspace> AddWorkspaceAsync(Workspace workspace);
        Task<List<Workspace>> GetWorkspacesAsync();
        Task<Workspace> GetWorkspaceByIdAsync(int id);
        Task<List<Workspace>> GetWorkspaceByCreateUserId(string userId);
        Task<Workspace> UpdateWorkspaceAsync(Workspace workspace);
        Task DeleteWorkspaceById(int id);
        Task RemoveWorkspaceAsync(int id);
    }
}
