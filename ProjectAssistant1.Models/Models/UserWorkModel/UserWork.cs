using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.UserWorkModel
{
    public class UserWork
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkId { get; set; }

        [Required]
        public int WorkspaceId { get; set; }
    }
}
