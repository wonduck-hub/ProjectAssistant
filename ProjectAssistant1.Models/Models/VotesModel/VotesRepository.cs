using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.Models.VotModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotesModel
{
    public class VotesRepository : IVotesRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public VotesRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<Votes> AddVotesAsync(Votes v)
        {
            Debug.Assert(v != null, "work is null");

            _context.Votes.Add(v);
            await _context.SaveChangesAsync();

            return v;
        }

        public async Task<List<Votes>> GetVotesByVotIdAsync(int votId)
        {
            Debug.Assert(votId > 0, "votId is null");

            List<Votes> v = new List<Votes>();
            v = await _context.Votes.Where(v => v.VotsId == votId).ToListAsync<Votes>();

            return v;
        }

        public async Task<bool> IsUsedByVotIdAndUserId(int votId, string userId)
        {
            var v = await _context.Votes.Where(v => v.VotsId == votId && v.UserId == userId).FirstOrDefaultAsync();
            if (v == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Task<Votes> RemoveVotesAsync(int votesId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateVotesTypeByVotIdAndUserId(int votId, string userId, bool voteType)
        {
            var v = await _context.Votes.Where(v => v.VotsId == votId && v.UserId == userId).FirstOrDefaultAsync();

            if(v == null)
            {
                return false;
            }

            v.VoteType = voteType;

            Debug.Assert(v != null, "Votes is null");

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
