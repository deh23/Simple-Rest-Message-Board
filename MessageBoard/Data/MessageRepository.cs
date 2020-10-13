using MessageBoard.Controllers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MessageBoard
{
    internal class MessageRepository : IMessageRepository
    {
        private List<string> _messages;
        public MessageRepository()
        {
            _messages = new List<string>();
        }
        public MessageResponse GetAll()
        {
            MessageResponse messages = new MessageResponse();
            messages.Messages = _messages;

            return messages;
        }

        public void Add(string message)
        {
            _messages.Add(message);
        }
    }
}