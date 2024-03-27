using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant.Models
{
    /// <summary>
    /// Users테이블에 대한 CRUD API 명세서 작성
    /// 
    /// </summary>
    public interface IUserRepository
    {
        User AddUser(User user);
        List<User> GetUsers();
        User GetUserById(int id);
        User UpdateUser(User user);
        void RemoveUser(int id);
    }
}
