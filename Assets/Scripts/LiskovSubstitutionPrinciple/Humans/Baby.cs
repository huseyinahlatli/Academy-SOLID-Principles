using UnityEngine;

public class Baby : LifeProcess
{
    public override void Feed()
    {
        Debug.Log("The baby is eating.");
    }

    public override void Sleep()
    {
        Debug.Log("Baby is sleeping.");
    }
}
