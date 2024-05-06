using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.WorkspaceWorkModel
{
    public class WorkspaceWork
    {
        public WorkspaceWork() { }

        public WorkspaceWork(int workId, int workspaceId)
        {
            WorkId = workId;
            WorkspaceId = workspaceId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkId { get; set; }

        [Required]
        public int WorkspaceId { get; set; }

        // Navigation properties
        public Work Work { get; set; }
        public Workspace Workspace { get; set; }
    }
}
