using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.ChatRoomModel
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public ChatRoomRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }

        public async Task<ChatRoom> AddChatRoomAsync(ChatRoom cr)
        {
            Debug.Assert(cr != null, "ChatRoom is null");

            this._context.ChatRooms.Add(cr);
            await _context.SaveChangesAsync();

            return cr;
        }

        public async Task DeleteChatRoomById(int id)
        {
            Debug.Assert(id > 0, id + " is not a valid id");

            ChatRoom cr = this._context.ChatRooms.Find(id);
            cr.IsDeleted = true;
            _context.ChatRooms.Update(cr);
            await _context.SaveChangesAsync();

        }

        public Task<List<ChatRoom>> GetChatRoomByCreateUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ChatRoom> GetChatRoomByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ChatRoom>> GetChatRoomByWorkspaceId(int? id)
        {
            Debug.Assert(id != null, "Workspace id is null");

            return await _context.ChatRooms.Where(w => w.WorkspaceId == id).ToListAsync();
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
