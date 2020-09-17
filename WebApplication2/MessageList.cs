using System.Collections.Generic;

namespace WebApplication2 {
    public class MessageList : IMessageList {
        private List<string> messages;

        public MessageList() {
            messages = new List<string>();
        }

        public void addMessage(string message) {
            messages.Add(message);
        }

        public string getMessageAt(int index) {
            if (index < messages.Count) {
                return messages[index];
            } else {
                return null;
            }
        }

        public bool removeMessage(string message) {
            return messages.Remove(message);
        }

        public string getLastMessage() {
            return messages[messages.Count - 1];
        }

        public bool clearMessages() {
            return false;
        }
    }
}