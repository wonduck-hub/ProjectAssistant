using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.UserModel;
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
            _context = context;
        }

        public async Task<WorkList> AddWorkListAsync(WorkList r)
        {
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
            if (workspaceId == null)
            {
                throw new ArgumentException("workspace Id cannot be null or empty.");
            }

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
