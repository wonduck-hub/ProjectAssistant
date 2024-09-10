using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.UserWorkModel
{
    public class UserWork
    {
        public UserWork(int workId, string userId, int workspaceId)
        {
            WorkId = workId;
            UserId = userId;
            WorkspaceId = workspaceId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkId { get; set; }

        [Required]
        public string UserId { get; set; }

        public int WorkspaceId { get; set; }

        // 관계용
        [JsonIgnore]
        virtual public User User { get; set; }
        [JsonIgnore]
        virtual public Work Work { get; set; }
        [JsonIgnore]
        virtual public Workspace Workspace { get; set; }
    }
}
