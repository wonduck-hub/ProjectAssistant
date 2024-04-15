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
        Task<Work> AddUserAsync(Work task);
        Task<List<Work>> GetUsersAsync();
        Task<Work> GetUserByIdAsync(string id);
        Task<Work> UpdateUserAsync(Work task);
        Work RemoveUserAsync(string id);
    }
}
