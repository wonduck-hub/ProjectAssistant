using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatRoomModel
{
    public interface IChatRoomRepository
    {
        Task<ChatRoom> AddChatRoomAsync(ChatRoom cr);
        Task<List<ChatRoom>> GetChatRoomsAsync();
        Task<ChatRoom> GetChatRoomByIdAsync(int id);
        Task<List<ChatRoom>> GetChatRoomByCreateUserId(string userId);
        Task<List<ChatRoom>> GetChatRoomByWorkspaceId(int id);
        Task<ChatRoom> UpdateChatRoomAsync(ChatRoom cr);
        Task DeleteChatRoomById(int id);
        Task RemoveChatRoomAsync(int id);
    }
}
