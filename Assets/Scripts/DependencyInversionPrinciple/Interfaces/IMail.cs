public interface IMail
{
    public string ToAddress { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    
    void SendMail();
}
