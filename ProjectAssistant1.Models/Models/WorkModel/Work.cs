using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CreateUserId { get; set; }
        public string? ModifiedUserId { get; set; }
        public string? TaskDetails { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int WorkListId { get; set; }
    }
}
