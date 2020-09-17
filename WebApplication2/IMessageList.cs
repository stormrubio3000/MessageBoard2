using System.Collections.Generic;

namespace WebApplication2 {
    public interface IMessageList {

        void addMessage(string message);
        bool removeMessage(string message);

        string getMessageAt(int index);
        
        string getLastMessage();

        bool clearMessages(); 
    }
}