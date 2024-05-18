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

            // 이미 존재하는 WorkspaceUser인지 확인합니다.
            var existingWorkspaceUser = await _context.WorkspaceUser
                .Where(wu => wu.AspNetUsersId == r.AspNetUsersId && wu.WorkspaceId == r.WorkspaceId)
                .FirstOrDefaultAsync();

            // 이미 존재하는 WorkspaceUser가 없을 경우에만 추가합니다.
            if (existingWorkspaceUser == null)
            {
                _context.WorkspaceUser.Add(r);
                await _context.SaveChangesAsync();
            }

            return r;
        }

        public async Task<List<WorkspaceUser>> GetWorkspaceUserByWorkspaceId(int workspaceId)
        {
            return await _context.WorkspaceUser
                    .Where(wu => wu.WorkspaceId == workspaceId && wu.Workspace.IsDeleted == false)
                    .Include(wu => wu.User)
                    .Include(wu => wu.Workspace)
                    .ToListAsync();
        }

        public async Task<List<WorkspaceUser>> GetWorkspaceUserByUserId(string userId)
        {
            return await _context.WorkspaceUser
                    .Where(wu => wu.AspNetUsersId == userId && wu.Workspace.IsDeleted == false)
                    .Include(wu => wu.User)
                    .Include(wu => wu.Workspace)
                    .ToListAsync();
        }

        public Task<List<WorkspaceUser>> GetWorkspaceUsers()
        {
            throw new NotImplementedException();
        }

        public async Task RemoveWorkspaceUserAsync(string userId, int workspaceId)
        {
            // WorkspaceUser 엔티티를 찾습니다.
            var workspaceUser = await _context.WorkspaceUser
                .Where(wu => wu.AspNetUsersId == userId && wu.WorkspaceId == workspaceId)
                .FirstOrDefaultAsync();

            if (workspaceUser != null)
            {
                // 해당하는 WorkspaceUser가 있으면 제거합니다.
                _context.WorkspaceUser.Remove(workspaceUser);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<WorkspaceUser> UpdateWorkspaceUserAsync(WorkspaceUser r)
        {
            // 업데이트할 WorkspaceUser를 조회합니다.
            var existingWorkspaceUser = await _context.WorkspaceUser
                .FirstOrDefaultAsync(wu => wu.Id == r.Id);

            if (existingWorkspaceUser != null)
            {
                // 필요한 업데이트 로직을 수행하세요.
                // 예를 들어, 업데이트할 속성 값을 변경하고 SaveChangesAsync를 호출하세요.
                existingWorkspaceUser.TaskCreationPermission = r.TaskCreationPermission;
                existingWorkspaceUser.UserInvitationPermission = r.UserInvitationPermission;

                await _context.SaveChangesAsync();
            }

            return existingWorkspaceUser;
        }

        public async Task<WorkspaceUser> GetWorkspaceUserByWorkspaceIdUserId(string userId, int workspaceId)
        {
            var workspaceUser = await _context.WorkspaceUser
                .Where(wu => wu.AspNetUsersId == userId && wu.WorkspaceId == workspaceId)
                .FirstOrDefaultAsync();

            return workspaceUser;
        }
    }
}
