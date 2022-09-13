using UnityEngine;

public class LifeManager : MonoBehaviour
{
    private const int Count = 25; 
    private void Start()
    {
        LifeProcess(new Baby());
        LifeProcess(new Old());
        LifeProcess(new Young());
        
        Debug.Log(new string('-', Count));
        YoungMan(new Young());
    }

    private void LifeProcess(LifeProcess lifeProcess)
    {
        lifeProcess.Feed();
        lifeProcess.Sleep();
    }
    
    private void YoungMan(Young young)
    {
        young.Feed();
        young.GoToWork();
        young.PlayGame();
        young.Sleep();
    }
}