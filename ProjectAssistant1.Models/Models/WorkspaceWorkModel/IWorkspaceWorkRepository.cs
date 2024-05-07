using ProjectAssistant1.Models.Models.UserWorkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceWorkModel
{
    public interface IWorkspaceWorkRepository
    {
        Task<WorkspaceWork> AddWorkspaceWorkAsync(WorkspaceWork r);
        Task<List<WorkspaceWork>> GetWorkspaceWorkByWorkspaceIdAsync(int workspaceId);
        Task<List<WorkspaceWork>> GetWorkspaceWorkByWorkIdAsync(int workId);
        Task<WorkspaceWork> UpdateWorkspaceWorkAsync(WorkspaceWork r);
        Task<WorkspaceWork> RemoveWorkspaceWorkAsync(int workId, int workspaceId);
    }
}
