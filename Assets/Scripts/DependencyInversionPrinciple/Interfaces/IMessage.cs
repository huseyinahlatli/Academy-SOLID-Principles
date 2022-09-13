public interface IMessage
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    
    void SendMessage();
}