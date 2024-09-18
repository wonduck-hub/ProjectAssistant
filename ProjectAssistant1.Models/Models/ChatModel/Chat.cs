using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using ProjectAssistant1.Models.Models.ChatRoomModel;
using ProjectAssistant1.Models.UserModel;

namespace ProjectAssistant1.Models.Models.ChatModel
{
    public class Chat
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNotification { get; set; }
        public int ChatRoomId { get; set; }
        public string UserId { get; set; }

        // Navigation property for the ChatRoom foreign key
        virtual public ChatRoom ChatRoom { get; set; }
        virtual public User User { get; set; }

        public Chat()
        {
        }

        public Chat(string text, int chatRoomId, string userId)
        {
            this.Text = text;
            this.ChatRoomId = chatRoomId;
            this.UserId = userId;
            this.Created = DateTimeOffset.Now;
        }

        public Chat(string text)
        {
            this.Text = text;
        }
    }
}
