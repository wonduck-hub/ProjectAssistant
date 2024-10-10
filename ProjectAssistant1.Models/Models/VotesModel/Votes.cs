using ProjectAssistant1.Models.Models.VotModel;
using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.VotesModel
{
    // 투표 한 것
    public class Votes
    {
        public int Id { get; set; }
        public int VotsId { get; set; }
        public string UserId { get; set; }
        public bool VoteType { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        virtual public User User { get; set; }
        [JsonIgnore]
        virtual public Vot Vots { get; set; }

        public Votes()
        {

        }

        public Votes(bool voteType, DateTimeOffset? created, User user, Vot vot)
        {
            VotsId = vot.Id;
            UserId = user.Id;
            VoteType = voteType;
            Created = created;
            User = user;
            Vots = vot;
        }
    }
}
