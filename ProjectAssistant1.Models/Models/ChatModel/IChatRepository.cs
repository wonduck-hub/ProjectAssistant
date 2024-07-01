using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatModel
{
    public interface IChatRepository
    {
        Task<Chat> AddChatAsync(Chat c);
        Task<List<Chat>> GetChatsAsync();
        Task<Chat> GetChatByIdAsync(int id);
        Task<List<Chat>> GetChatByCreateUserId(string userId);
        Task<Chat> UpdateChatAsync(Chat c);
        Task DeleteChatById(int id);
        Task RemoveChatAsync(int id);
    }
}
