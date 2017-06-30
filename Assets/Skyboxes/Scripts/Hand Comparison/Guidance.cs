using UnityEngine;

public class Guidance
{
    public Vector3 position;
    public Quaternion rotation;

    public Guidance(Vector3 position, Quaternion rotation)
    {
        this.position = position;
        this.rotation = rotation;
    }

    public Guidance(Transform obj)
    {
        this.position = obj.localPosition;
        this.rotation = obj.localRotation;
    }
}
