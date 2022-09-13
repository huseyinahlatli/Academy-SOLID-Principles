using UnityEngine;

public class Young : LifeProcess, IWorkable, IPlayable
{
    public override void Feed()
    {
        Debug.Log("The young man is eating.");
    }

    public override void Sleep()
    {
        Debug.Log("Young man is sleeping.");
    }

    public void GoToWork()
    {
        Debug.Log("Young man going to work.");
    }

    public void PlayGame()
    {
        Debug.Log("Young man playing games.");
    }
}
