using ProjectAssistant1.Models.Models.ChatRoomModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotModel
{
    public class Vot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DetailText { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkspaceId { get; set; }

        // Navigation property for the Workspace foreign key
        [JsonIgnore]
        virtual public Workspace Workspace { get; set; }

        public Vot()
        {

        }

        public Vot(string name, string detailText, DateTimeOffset? created, Workspace w)
        {
            Name = name;
            DetailText = detailText;
            Created = created;
            WorkspaceId = w.Id;
            Workspace = w;
        }
    }
}
