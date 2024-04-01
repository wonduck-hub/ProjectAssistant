using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.WorkspaceModel
{
    public interface IWorkspaceRepositoryAsync
    {
        Task<Workspace> AddWorkspaceAsync(Workspace workspace);
        Task<List<Workspace>> GetWorkspacesAsync();
        Task<Workspace> GetWorkspaceByIdAsync(int id);
        Task<Workspace> UpdateWorkspaceAsync(Workspace workspace);
        Task RemoveWorkspaceAsync(int id);
    }
}
