using UnityEngine;

public class Old : LifeProcess
{
    public override void Feed()
    {
        Debug.Log("The old man is eating.");
    }

    public override void Sleep()
    {
        Debug.Log("Old man is sleeping");
    }
}
