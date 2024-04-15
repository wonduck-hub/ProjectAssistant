using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public class ListWorkspaceRepository : IListWorkspaceRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public ListWorkspaceRepository(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public Task<ListWorkspace> AddListWorkspaceAsync(ListWorkspace r)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListWorkspace>> GetListWorkspaceByListIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListWorkspace>> GetListWorkspaceByWorkspaceIdAsync()
        {
            throw new NotImplementedException();
        }

        public Work RemoveListWorkspaceAsync(string userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public Task<ListWorkspace> UpdateListWorkspaceAsync(ListWorkspace r)
        {
            throw new NotImplementedException();
        }
    }
}
