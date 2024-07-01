using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatModel
{
    public class ChatRepository : IChatRepository
    {
        public Task<Chat> AddChatAsync(Chat c)
        {
            throw new NotImplementedException();
        }

        public Task DeleteChatById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Chat>> GetChatByCreateUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Chat> GetChatByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Chat>> GetChatsAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveChatAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Chat> UpdateChatAsync(Chat c)
        {
            throw new NotImplementedException();
        }
    }
}
