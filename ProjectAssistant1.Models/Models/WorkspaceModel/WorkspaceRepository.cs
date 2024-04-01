using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
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
            _context.Workspaces.Add(workspace);
            await _context.SaveChangesAsync();

            return workspace;
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
                _context.Workspaces.Remove(workspace);
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
