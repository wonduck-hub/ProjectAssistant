using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatModel
{
    public class ChatRepository : IChatRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public ChatRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<Chat> AddChatAsync(Chat c)
        {
            Debug.Assert(c != null, "Chat is null");
            this._context.Chats.Add(c);
            await _context.SaveChangesAsync();

            return c;
        }

        public Task DeleteChatById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Chat>> GetChatByCreateChatRoomId(int id)
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
