using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotModel
{
    public class VotRepository : IVotRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public VotRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<Vot> AddVotAsync(Vot v)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vot>> GetVotByWorkspaceIdAsync(int w)
        {
            throw new NotImplementedException();
        }

        public async Task<Vot> RemoveVotAsync(int votId)
        {
            throw new NotImplementedException();
        }

        public async Task<Vot> UpdateVotAsync(Vot v)
        {
            throw new NotImplementedException();
        }
    }
}
