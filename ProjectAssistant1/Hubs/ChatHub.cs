using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

using ProjectAssistant1.Models;
using ProjectAssistant1.Models.Models.ChatModel;
using System.Linq;
using System;
using ProjectAssistant1.Models.Models.ChatRoomModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectAssistant1.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ProjectAssistantDbContext _context;

        public ChatHub(ProjectAssistantDbContext context)
        {
            _context = context;
        }

        public async Task SendMessageToChatRoom(ChatRoom selectedChatRoom, string userId, string userInput)
        {
            Chat chatMessage = new Chat(userInput, selectedChatRoom.Id, userId);

            _context.Chats.Add(chatMessage);
            await _context.SaveChangesAsync();

            await Clients.Group(selectedChatRoom.Id.ToString()).SendAsync("ReceiveMessage", chatMessage);
        }

        public async Task JoinRoom(ChatRoom chatRoom)
        {
            Debug.WriteLine("Join the chatroom - server");
            await Groups.AddToGroupAsync(Context.ConnectionId, chatRoom.Id.ToString());

            List<Chat> messages = _context.Chats
                .Where(m => m.ChatRoom.Id == chatRoom.Id)
                .OrderBy(m => m.Created)
                .ToList();
            foreach (var message in messages)
            {
                Debug.WriteLine(message.Text);
            }
            await Clients.Caller.SendAsync("LoadMessages", messages);
        }

        public async Task LeaveRoom(ChatRoom room)
        {
            Debug.WriteLine("leave " + room.Id.ToString() + " room - server");
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, room.Id.ToString());
        }
    }
}
