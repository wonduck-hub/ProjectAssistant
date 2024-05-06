using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(r != null, "WorkspaceUser is null");

            _context.WorkspaceUser.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }

        public async Task<List<WorkspaceUser>> GetUsersByWorkspaceId(int workspaceId)
        {
            return await _context.WorkspaceUser
                    .Where(wu => wu.WorkspaceId == workspaceId)
                    .Include(wu => wu.User)
                    .ToListAsync();
        }

        public async Task<List<WorkspaceUser>> GetWorkspacesByUserId(string userId)
        {
            return await _context.WorkspaceUser
                    .Where(wu => wu.AspNetUsersId == userId)
                    .Include(wu => wu.Workspace)
                    .ToListAsync();
        }

        public async Task<List<WorkspaceUser>> GetWorkspaceUserByUserIdAsync(string userId)
        {
            Debug.Assert(userId != null, "userId is null");

            var workspaceUsers = await _context.WorkspaceUser.Where(wu => wu.AspNetUsersId == userId).ToListAsync();

            return workspaceUsers;

        }

        public async Task<List<WorkspaceUser>> GetWorkspaceUserByWorkspaceIdAsync(int id)
        {
            Debug.Assert(id > 0, "userId is null");

            var workspaceUsers = await _context.WorkspaceUser.Where(wu => wu.WorkspaceId == id).ToListAsync();

            return workspaceUsers;
        }

        public Task<List<WorkspaceUser>> GetWorkspaceUsers()
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
