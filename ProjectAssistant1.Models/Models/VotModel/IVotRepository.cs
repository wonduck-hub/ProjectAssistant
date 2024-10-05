using ProjectAssistant1.Models.Models.UserWorkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotModel
{
    public interface IVotRepository
    {
        Task<Vot> AddVotAsync(Vot v);
        Task<List<Vot>> GetVotByWorkspaceIdAsync(int w);
        Task<Vot> UpdateVotAsync(Vot v);
        Task<Vot> RemoveVotAsync(int votId);
    }
}
