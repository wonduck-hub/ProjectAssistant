﻿using System.Collections.Generic;
using System;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.ChatModel;
using System.Text.Json.Serialization;
using ProjectAssistant1.Models.Models.PersonalScheduleModel;

namespace ProjectAssistant1.Models.UserModel
{
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
        [JsonIgnore]
        virtual public IEnumerable<WorkspaceUser> WorkspaceUsers { get; set; }
        [JsonIgnore]
        virtual public IEnumerable<UserWork> UserWorks { get; set; }
        [JsonIgnore]
        virtual public IEnumerable<Chat> Chats { get; set; }
        [JsonIgnore]
        virtual public IEnumerable<PersonalSchedule> PersonalSchedules { get; set; }
    }
}
