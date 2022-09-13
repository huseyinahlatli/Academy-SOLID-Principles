using System.Collections.Generic;

public class Notification
{
    private readonly ICollection<IMessage> _messages;
    private readonly IMail _mail;

    public Notification(ICollection<IMessage> messages, IMail mail)
    {
        _messages = messages;
        _mail = mail;
    }

    public void SendMessages()
    {
        foreach (var message in _messages)
        {
            message.SendMessage();
        }
    }

    public void SendMails()
    {
        _mail.SendMail();
    }
}
