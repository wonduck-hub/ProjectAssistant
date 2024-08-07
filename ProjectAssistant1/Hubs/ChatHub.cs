using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

using ProjectAssistant1.Models;
using ProjectAssistant1.Models.Models.ChatModel;
using System.Linq;
using System;
using ProjectAssistant1.Models.Models.ChatRoomModel;

namespace ProjectAssistant1.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ProjectAssistantDbContext _context;

        public ChatHub(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task SendMessageToChatRoom(ChatRoom chatRoom, string userName, string message)
        {
            var chatMessage = new Chat(message, chatRoom);

            _context.Chats.Add(chatMessage);
            await _context.SaveChangesAsync();

            await Clients.Group(chatRoom.Name).SendAsync("ReceiveMessage", userName, message);
        }

        public async Task LoadMessages(string chatRoomName)
        {
            var messages = _context.Chats
                .Where(m => m.ChatRoom.Name == chatRoomName)
                .OrderBy(m => m.Created)
                .ToList();

            await Clients.Caller.SendAsync("LoadMessages", messages);
        }

        public async Task JoinRoom(string chatRoomName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatRoomName);
            await LoadMessages(chatRoomName);
        }

        public async Task LeaveRoom(string roomName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }
    }
}
