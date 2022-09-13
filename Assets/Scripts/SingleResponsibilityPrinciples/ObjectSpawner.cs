using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    private ObjectManager _objectManager;

    private void Start()
    {
        _objectManager = gameObject.AddComponent<ObjectManager>();
    }

    public void SpawnObject()
    {
        var spawnObject = Instantiate (objects[Random.Range(0, objects.Count)]);
        _objectManager.SetProperties(spawnObject);
    }
}