using UnityEngine;

public class Mover : MonoBehaviour
{
    public void Move(Transform target, Vector3 movement)
    {
        var moveable = target.GetComponent<IMovable>();

        if (moveable != null)
        {
            moveable.Move(movement);
            Debug.Log(moveable.Position);
        }
    }    
}
