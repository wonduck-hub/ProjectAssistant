using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            _context = context;
        }

        public async Task<WorkList> AddWorkListAsync(WorkList r)
        {
            Debug.Assert(r != null, "workList is null");

            _context.Lists.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }

        public Task<List<WorkList>> GetWorkListsByUserIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<WorkList>> GetWorkListsByWorkspaceIdAsync(int workspaceId)
        {
            Debug.Assert(workspaceId != 0, "workspaceId is 0");

            return await _context.Lists.Where(wu => wu.WorkspaceId == workspaceId).ToListAsync();
        }

        public Work RemoveWorkListAsync(string userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkList> UpdateWorkListAsync(WorkList r)
        {
            throw new NotImplementedException();
        }
    }
}
