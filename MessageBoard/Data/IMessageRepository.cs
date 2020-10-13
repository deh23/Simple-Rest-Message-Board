using System.Collections.Generic;

namespace MessageBoard.Controllers
{
    public interface IMessageRepository
    {
        MessageResponse GetAll();
        void Add(string message);
    }
}