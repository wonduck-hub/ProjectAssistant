using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public interface IWorkRepository
    {
        Task<Work> AddWorkAsync(Work task);
        Task DeleteWorkById(int id);
        Task<List<Work>> GetWorksAsync();
        Task<List<Work>> GetWorkByListIdAsync(int listId);
        Task<Work> UpdateWorkAsync(Work task);
        Work RemoveWorkAsync(int id);
    }
}
