using UnityEngine;

public interface IMovable
{
    int Speed { get; }
    Vector3 Position { get; }

    void Move(Vector3 direction);
}