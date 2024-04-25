using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.WorkspaceModel
{
    public class WorkspaceRepository : IWorkspaceRepositoryAsync
    {
        private readonly ProjectAssistantDbContext _context;

        public WorkspaceRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<Workspace> AddWorkspaceAsync(Workspace workspace)
        {
            Debug.Assert(workspace != null, "workspace is null");

            _context.Workspaces.Add(workspace);
            await _context.SaveChangesAsync();

            return workspace;
        }

        public async Task DeleteWorkspace(int id)
        {
            Workspace temp = await _context.Workspaces.FindAsync(id);

            temp.IsDeleted = true;

            _context.Entry(temp).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Workspace>> GetWorkspaceByCreateUserId(string userId)
        {
            Debug.Assert(userId != null, "userId is null");

            return await _context.Workspaces.Where(w => w.CreateUserId == userId).ToListAsync();
        }

        public async Task<Workspace> GetWorkspaceByIdAsync(int id)
        {
            return await _context.Workspaces.FindAsync(id);
        }

        public async Task<List<Workspace>> GetWorkspacesAsync()
        {
            return await _context.Workspaces.ToListAsync();
        }



        public async Task RemoveWorkspaceAsync(int id)
        {
            var workspace = await _context.Workspaces.FindAsync(id);
            if (workspace != null)
            {
                //_context.Workspaces.Remove(workspace);
                //await _context.SaveChangesAsync();
                // 해당 Workspace를 참조하는 모든 WorkspaceUser 항목을 찾습니다.
                var workspaceUsers = _context.WorkspaceUser.Where(wu => wu.WorkspaceId == id);

                // 찾은 모든 WorkspaceUser 항목을 삭제합니다.
                _context.WorkspaceUser.RemoveRange(workspaceUsers);

                // 해당 Workspace를 참조하는 모든 Lists 항목을 찾습니다.
                var lists = _context.Lists.Where(l => l.WorkspaceId == id);

                // 찾은 모든 Lists 항목을 삭제합니다.
                _context.Lists.RemoveRange(lists);

                // Workspace를 삭제합니다.
                _context.Workspaces.Remove(workspace);

                // 변경 사항을 저장합니다.
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Workspace> UpdateWorkspaceAsync(Workspace workspace)
        {
            _context.Entry(workspace).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return workspace;
        }
    }
}
