using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.Models.UserWorkModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceWorkModel
{
    public class WorkspaceWorkRepository : IWorkspaceWorkRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public WorkspaceWorkRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<WorkspaceWork> AddWorkspaceWorkAsync(WorkspaceWork r)
        {
            Debug.Assert(r != null, "WorkspaceUser is null");

            // 이미 존재하는 WorkspaceUser인지 확인합니다.
            var existingWorkspaceUser = await _context.WorkspaceWork
                .Where(wu => wu.WorkId == r.WorkId && wu.WorkspaceId == r.WorkspaceId)
                .FirstOrDefaultAsync();

            // 이미 존재하는 WorkspaceUser가 없을 경우에만 추가합니다.
            if (existingWorkspaceUser == null)
            {
                _context.WorkspaceWork.Add(r);
                await _context.SaveChangesAsync();
            }

            return r;
        }

        public Task<List<WorkspaceWork>> GetWorkspaceWorkByWorkIdAsync(int workId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<WorkspaceWork>> GetWorkspaceWorkByWorkspaceIdAsync(int workspaceId)
        {
            return await _context.WorkspaceWork
                    .Where(wu => wu.WorkspaceId == workspaceId)
                    .Include(wu => wu.Work)
                    .Include(wu => wu.Workspace)
                    .ToListAsync();
        }

        public async Task<WorkspaceWork> RemoveWorkspaceWorkAsync(int workId, int workspaceId)
        {
            // 해당하는 WorkspaceWork를 찾습니다.
            var workspaceWork = await _context.WorkspaceWork
                .Where(ww => ww.WorkId == workId && ww.WorkspaceId == workspaceId)
                .FirstOrDefaultAsync();

            if (workspaceWork != null)
            {
                // 찾은 WorkspaceWork를 제거합니다.
                _context.WorkspaceWork.Remove(workspaceWork);
                await _context.SaveChangesAsync();
            }

            return workspaceWork;
        }


        public Task<WorkspaceWork> UpdateWorkspaceWorkAsync(WorkspaceWork r)
        {
            throw new NotImplementedException();
        }
    }
}
