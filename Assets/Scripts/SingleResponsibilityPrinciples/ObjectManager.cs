using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private readonly ObjectProperties _objectPreProperties = new ObjectProperties();
    private readonly ObjectInitialValues _objectInitialValues = new ObjectInitialValues();
    
    private void GetProperties()
    {
        _objectPreProperties.ObjectColor = _objectInitialValues.GetColor();
        _objectPreProperties.ObjectPosition = _objectInitialValues.GetPosition();
    }

    public void SetProperties(GameObject spawnObject)
    {
        GetProperties();
    
        spawnObject.GetComponent<Renderer>().material.color = _objectPreProperties.ObjectColor;
        spawnObject.transform.position = _objectPreProperties.ObjectPosition;
    }
}

