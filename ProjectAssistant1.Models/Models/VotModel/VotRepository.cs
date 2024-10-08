using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(v != null, "work is null");

            _context.Vots.Add(v);
            await _context.SaveChangesAsync();

            return v;
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
