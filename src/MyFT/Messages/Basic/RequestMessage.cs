namespace MyFT.Messages.Basic
{
    public class RequestMessage
    {
        public MessageType Type { get; set; }
    }
    
    public enum MessageType
    {
        Hello,
        GoodBye
    }
}
