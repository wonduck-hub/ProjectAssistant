using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAssistant1.Models.UserWorkspacesModel
{
    public class UserWorkspace
    {
        public UserWorkspace() { }

        public UserWorkspace(string userId, int workspaceId) 
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

        // Navigation properties
        public virtual User RelatedUser { get; set; }
        public virtual Workspace RelatedWorkspace { get; set; }
    }
}
