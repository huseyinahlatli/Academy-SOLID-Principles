using UnityEngine;

public class WhatsApp : IMessage
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    
    public void SendMessage()
    {
        Debug.Log("WhatsApp message sent.");
        Debug.Log("Phone Number: " + PhoneNumber);
        Debug.Log("Message: " + Message);
    }
}
