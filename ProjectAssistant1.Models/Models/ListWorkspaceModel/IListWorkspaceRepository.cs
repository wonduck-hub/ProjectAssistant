using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public interface IListWorkspaceRepository
    {
        Task<ListWorkspace> AddListWorkspaceAsync(ListWorkspace r);
        Task<List<ListWorkspace>> GetListWorkspaceByListIdAsync(string userId);
        Task<List<ListWorkspace>> GetListWorkspaceByWorkspaceIdAsync();
        Task<ListWorkspace> UpdateListWorkspaceAsync(ListWorkspace r);
        Work RemoveListWorkspaceAsync(string userId, int workspaceId);
    }
}
