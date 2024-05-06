using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceUserModel
{
    public class WorkspaceUser
    {
        public WorkspaceUser() { }

        public WorkspaceUser(string UserId, int workspaceId)
        {
            AspNetUsersId = UserId;
            WorkspaceId = workspaceId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string AspNetUsersId { get; set; }

        [Required]
        public int WorkspaceId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Workspace Workspace { get; set; }
    }
}
