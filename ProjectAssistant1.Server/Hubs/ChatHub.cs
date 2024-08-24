using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

using ProjectAssistant1.Models;
using ProjectAssistant1.Models.Models.ChatModel;
using System.Linq;
using System;
using ProjectAssistant1.Models.Models.ChatRoomModel;
using System.Collections.Generic;

namespace ProjectAssistant1.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ProjectAssistantDbContext _context;

        public ChatHub(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task SendMessageToChatRoom(ChatRoom selectedChatRoom, string userInput)
        {
            Chat chatMessage = new Chat(userInput, selectedChatRoom);

            _context.Chats.Add(chatMessage);
            await _context.SaveChangesAsync();

            await Clients.Group(selectedChatRoom.Name).SendAsync("ReceiveMessage", chatMessage);
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
