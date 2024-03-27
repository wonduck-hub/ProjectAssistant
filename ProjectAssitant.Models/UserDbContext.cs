using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Install-Pacage Microsoft.EntityFrameworkCore.SqlServer
// Install-Pacage System.Configureation.ConfigurationManager
namespace ProjectAssistant.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        {
            
        }

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 닷넷 프레임워크 기반에서 호출되는 코드 영역:
            // App.config 또는 Web.config의 연결 문자열 사용
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = 
                    ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        /// <summary>
        /// Users테이블을 context개체로 사용할 때 Users로 사용하겠다는 의미
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
