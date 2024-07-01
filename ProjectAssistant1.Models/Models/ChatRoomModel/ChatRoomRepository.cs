using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatRoomModel
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        public Task<ChatRoom> AddChatRoomAsync(ChatRoom cr)
        {
            throw new NotImplementedException();
        }

        public Task DeleteChatRoomById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChatRoom>> GetChatRoomByCreateUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ChatRoom> GetChatRoomByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChatRoom>> GetChatRoomsAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveChatRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChatRoom> UpdateChatRoomAsync(ChatRoom cr)
        {
            throw new NotImplementedException();
        }
    }
}
