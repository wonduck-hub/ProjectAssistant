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

        public WorkspaceUser(string userId, int workspaceId)
        {
            AspNetUsersId = userId;
            WorkspaceId = workspaceId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string AspNetUsersId { get; set; }

        [Required]
        public int WorkspaceId { get; set; }
    }
}
