using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public class ListWorkspace
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ListId { get; set; }

        [Required]
        public int WorkspaceId { get; set; }
    }
}
