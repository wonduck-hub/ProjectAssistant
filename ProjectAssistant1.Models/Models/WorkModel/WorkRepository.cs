using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(task != null, "work is null");

            _context.Works.Add(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task DeleteWorkById(int id)
        {
            Work temp = await _context.Works.FindAsync(id);

            temp.IsDeleted = true;

            _context.Entry(temp).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Work>> GetWorkByListIdAsync(int listId)
        {
            Debug.Assert(listId != 0, "listId is 0");

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

        public async Task<Work> UpdateWorkAsync(Work work)
        {
            _context.Entry(work).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return work;
        }
    }
}
