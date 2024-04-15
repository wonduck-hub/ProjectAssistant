using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.UserWorkModel
{
    public interface IUserWorkRepository
    {
        Task<UserWork> AddUserWorkAsync(UserWork r);
        Task<List<UserWork>> GetUserWorkByUserIdAsync(string userId);
        Task<List<UserWork>> GetUserWorkByWorkspaceIdAsync();
        Task<UserWork> UpdateUserWorkAsync(UserWork r);
        Work RemoveUserWorkAsync(string userId, int listId);
    }
}
