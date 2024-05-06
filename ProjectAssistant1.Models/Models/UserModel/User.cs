using System.Collections.Generic;
using System;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.UserWorkModel;

namespace ProjectAssistant1.Models.UserModel { 
    public class User
    {
        public string Id { get; set; }
        public string? UserName { get; set; }

        public string? ProfilePicture { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }

        // 관계용
        public IEnumerable<WorkspaceUser> WorkspaceUsers { get; set; }
        public IEnumerable<UserWork> UserWorks { get; set; }
    }
}
