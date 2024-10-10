using ProjectAssistant1.Models.Models.VotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotesModel
{
    public interface IVotesRepository
    {
        Task<Votes> AddVotesAsync(Votes v);
        Task<List<Votes>> GetVotesByVotIdAsync(int w);
        Task<bool> IsUsedByVotIdAndUserId(int votId, string userId);
        Task<bool> UpdateVotesTypeByVotIdAndUserId(int votId, string userId, bool votType);
        Task<Votes> RemoveVotesAsync(int votesId);
    }
}
