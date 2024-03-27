using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant.Models
{
    /// <summary>
    /// [2] 모델 클래스: Video 모델 클래스 == Users 테이블과 일대일 매핑
    /// Users => User, UserModel, UserViewModel, UserBase, UserEntity... 처럼 이름을 만든다
    /// 
    /// </summary>
    public class User : IUserRepository
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 생성일
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 이메일
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 비밀번호
        /// </summary>
        public string? Password { get; set; }

        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
