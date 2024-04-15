using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ListModel
{
    public class WorkListRepository : IWorkListRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public WorkListRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<WorkList> AddWorkListAsync(WorkList r)
        {
            _context.Lists.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }

        public Task<List<WorkList>> GetWorkListByUserIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkList>> GetWorkListByWorkspaceIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveWorkListAsync(string userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkList> UpdateWorkListAsync(WorkList r)
        {
            throw new NotImplementedException();
        }
    }
}
