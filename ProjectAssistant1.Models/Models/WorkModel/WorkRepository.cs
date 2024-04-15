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

        public Task<Work> AddUserAsync(Work task)
        {
            throw new NotImplementedException();
        }

        public Task<Work> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Work>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Work RemoveUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Work> UpdateUserAsync(Work task)
        {
            throw new NotImplementedException();
        }
    }
}
