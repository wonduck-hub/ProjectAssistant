using Microsoft.EntityFrameworkCore;
using System.Configuration;

using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.WorkspaceModel;
using ProjectAssistant1.Models.UserWorkspacesModel;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.ListModel;
using ProjectAssistant1.Models.Models;
using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.WorkspaceWorkModel;

namespace ProjectAssistant1.Models
{
    public class ProjectAssistantDbContext : DbContext
    {
        public ProjectAssistantDbContext()
        {

        }

        public ProjectAssistantDbContext(DbContextOptions<ProjectAssistantDbContext> options)
            : base(options)
        {
            // 공식과 같은 코드
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 닷넷 프레임워크 기반에서 호출되는 코드 영역 .net core에서 필요하지 않을 수 있다.
            // App.config 또는 Web.config의 연결 문자열 사용
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 테이블 간의 관계를 설정하는 함수다.
            modelBuilder.Entity<WorkspaceUser>()
                .HasOne(wu => wu.User)
                .WithMany(u => u.WorkspaceUsers)
                .HasForeignKey(wu => wu.AspNetUsersId);

            modelBuilder.Entity<WorkspaceUser>()
                .HasOne(wu => wu.Workspace)
                .WithMany(w => w.WorkspaceUsers)
                .HasForeignKey(wu => wu.WorkspaceId);

            modelBuilder.Entity<UserWork>()
                .HasOne(wu => wu.User)
                .WithMany(u => u.UserWorks)
                .HasForeignKey(wu => wu.UserId);

            modelBuilder.Entity<UserWork>()
                .HasOne(wu => wu.Work)
                .WithMany(w => w.UserWorks)
                .HasForeignKey(wu => wu.WorkId);

            modelBuilder.Entity<WorkspaceWork>()
                .HasOne(wu => wu.Work)
                .WithMany(u => u.WorkspaceWorks)
                .HasForeignKey(wu => wu.WorkId);

            modelBuilder.Entity<WorkspaceWork>()
                .HasOne(wu => wu.Workspace)
                .WithMany(w => w.WorkspaceWorks)
                .HasForeignKey(wu => wu.WorkspaceId);

            modelBuilder.Entity<UserWork>()
                .HasOne(uw => uw.Workspace)
                .WithMany(w => w.UserWorks)
                .HasForeignKey(uw => uw.WorkspaceId);

        }


        public DbSet<User> AspNetUsers { get; set; }

        public DbSet<Workspace> Workspaces { get; set; }

        // UserWorkspaces 대신 WorkspaceUser 사용
        public DbSet<UserWorkspace> UserWorkspaces { get; set; }

        public DbSet<WorkspaceUser> WorkspaceUser { get; set; }

        public DbSet<WorkList> Lists { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<ListWorkspace> ListWorkspace { get; set; }

        public DbSet<UserWork> UserWork { get; set; }

        public DbSet<WorkspaceWork> WorkspaceWork { get; set; }
    }
}
