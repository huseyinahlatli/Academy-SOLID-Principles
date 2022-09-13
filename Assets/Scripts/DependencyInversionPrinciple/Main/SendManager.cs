using UnityEngine;

public class SendManager : MonoBehaviour
{
    private const string PhoneNumber = "0507 889 2485";
    private const string TestMessage = "Test Message";

    private void Start()
    {
        SendEMail();
        SendSmsMessage();
        SendWhatAppMessage();
    }

    private void SendEMail()
    {
        Email eMail = new Email
        {
            ToAddress = "huseyinahlatli@gmail.com",
            Subject = "Test Mail",
            Content = "There is no content yet."
        };
        eMail.SendMail();
    }

    private void SendSmsMessage()
    {
        Sms sms = new Sms
        {
            PhoneNumber = PhoneNumber,
            Message = TestMessage
        };
        sms.SendMessage();
    }

    private void SendWhatAppMessage()
    {
        WhatsApp whatsApp = new WhatsApp
        {
            PhoneNumber = PhoneNumber,
            Message = TestMessage
        };
        whatsApp.SendMessage();
    }
}


