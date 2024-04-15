using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceUserModel
{
    public class WorkspaceUserRepository : IWorkspaceUserRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public WorkspaceUserRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }
        public async Task<WorkspaceUser> AddWorkspaceUserAsync(WorkspaceUser r)
        {
            _context.WorkspaceUser.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }

        public async Task<List<WorkspaceUser>> GetWorkspaceUserByUserIdAsync(string userId)
        {
            if (userId == null)
            {
                throw new ArgumentException("User or User Id cannot be null or empty.");
            }

            var workspaceUsers = await _context.WorkspaceUser.Where(wu => wu.AspNetUsersId == userId).ToListAsync();

            return workspaceUsers;

        }

        public Task<List<WorkspaceUser>> GetWorkspaceUserByWorkspaceIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveWorkspaceUserAsync(string userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkspaceUser> UpdateWorkspaceUserAsync(WorkspaceUser r)
        {
            throw new NotImplementedException();
        }
    }
}
