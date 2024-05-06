using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.UserWorkModel
{
    public class UserWorkRepository : IUserWorkRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public UserWorkRepository(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task<UserWork> AddUserWorkAsync(UserWork newUserWork)
        {
            Debug.Assert(newUserWork != null, "workList is null");

            var existingWorkspaceUser = await _context.UserWork
                .Where(wu => wu.UserId == newUserWork.UserId && wu.WorkspaceId == newUserWork.WorkspaceId && wu.WorkId == newUserWork.WorkId)
                .FirstOrDefaultAsync();

            // 이미 존재하는 WorkspaceUser가 없을 경우에만 추가합니다.
            if (existingWorkspaceUser == null)
            {
                _context.UserWork.Add(newUserWork);
                await _context.SaveChangesAsync();
            }

            return newUserWork;
        }

        public Task<List<UserWork>> GetUserWorkByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserWork>> GetUserWorkByWorkIdAsync(int workId)
        {
            return await _context.UserWork
                    .Where(wu => wu.WorkId == workId)
                    .Include(wu => wu.User)
                    .Include(wu => wu.Workspace)
                    .ToListAsync();
        }

        public async Task<Work> RemoveUserWorkAsync(string userId, int workId, int workspaceId)
        {
            // UserWork 엔티티를 찾습니다.
            var userWork = await _context.UserWork
                .Where(uw => uw.UserId == userId && uw.WorkId == workId && uw.WorkspaceId == workspaceId)
                .FirstOrDefaultAsync();

            if (userWork == null)
            {
                // 해당하는 UserWork가 없으면 null을 반환합니다.
                return null;
            }

            // UserWork 엔티티를 제거합니다.
            _context.UserWork.Remove(userWork);
            await _context.SaveChangesAsync();

            // 제거된 작업을 반환합니다.
            return userWork.Work;
        }

        public Task<UserWork> UpdateUserWorkAsync(UserWork r)
        {
            throw new NotImplementedException();
        }
    }
}
