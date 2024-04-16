using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public class WorkRepository : IWorkRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public WorkRepository(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task<Work> AddWorkAsync(Work task)
        {
            _context.Works.Add(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<List<Work>> GetWorkByListIdAsync(int listId)
        {
            if (listId == null)
            {
                throw new ArgumentException("workspace Id cannot be null or empty.");
            }

            return await _context.Works.Where(wu => wu.ListId == listId).ToListAsync();
        }

        public Task<List<Work>> GetWorksAsync()
        {
            throw new NotImplementedException();
        }

        public Work RemoveWorkAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Work> UpdateWorkAsync(Work task)
        {
            throw new NotImplementedException();
        }
    }
}
