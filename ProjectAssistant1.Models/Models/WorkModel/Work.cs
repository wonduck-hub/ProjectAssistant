﻿using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.WorkspaceWorkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool IsSuccess { get; set; }
        public DateTimeOffset? SuccessDate { get; set; }
        public string? CreateUserId { get; set; }
        public string? ModifiedUserId { get; set; }
        public string? TaskDetails { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int ListId { get; set; }

        // 관계용
        [JsonIgnore]
        virtual public IEnumerable<UserWork> UserWorks { get; set; }
        [JsonIgnore]
        virtual public IEnumerable<WorkspaceWork> WorkspaceWorks { get; set; }
    }
}
