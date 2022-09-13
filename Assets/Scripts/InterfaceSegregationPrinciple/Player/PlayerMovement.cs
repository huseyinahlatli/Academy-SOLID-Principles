using UnityEngine;

public class PlayerMovement : Mover, IMovable
{
    public int Speed { get; }
    public Vector3 Position { get; }
    
    public void Move(Vector3 direction)
    {
        
    }
    
    public PlayerMovement(int speed, Vector3 position)
    {
        Speed = speed;
        Position = position;
    }
}