using UnityEngine;

public class Sms : IMessage
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    
    public void SendMessage()
    {
        Debug.Log("Sms Message sent.");
        Debug.Log("Phone Number: " + PhoneNumber);
        Debug.Log("Message: " + Message);
    }
}
