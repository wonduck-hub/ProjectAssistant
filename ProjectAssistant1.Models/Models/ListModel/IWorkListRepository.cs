using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ListModel
{
    public interface IWorkListRepository
    {
        Task<WorkList> AddWorkListAsync(WorkList r);
        Task<List<WorkList>> GetWorkListsByUserIdAsync();
        Task<List<WorkList>> GetWorkListsByWorkspaceIdAsync(int workspaceId);
        Task<WorkList> UpdateWorkListAsync(WorkList r);
        Work RemoveWorkListAsync(string userId, int workspaceId);
    }
}
