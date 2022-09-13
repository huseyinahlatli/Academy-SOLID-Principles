using UnityEngine;

public class Email : IMail
{
    public string ToAddress { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    
    public void SendMail()
    {
        Debug.Log("E-Mail sent.");
        Debug.Log("To Address: " + ToAddress);
        Debug.Log("Subject: " + Subject);
        Debug.Log("Content: " + Content);
    }
}