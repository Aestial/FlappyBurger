using UnityEngine;
using NaughtyAttributes;

/// <summary>
/// ChildrenDistance is a script that sets the distance between two children of a GameObject.
/// </summary>

public class ChildrenDistance2D : MonoBehaviour
{
    [SerializeField] private Transform childrenPositive;
    [SerializeField] private Transform childrenNegative;
    public Axis2D axis;
    public float distance;
    
    [Button]
    public void SetDistance()
    {  
        float halfDistance = distance / 2;
        Vector3 translation = Vector3.zero;
        switch (axis)
        {
            case Axis2D.X:
                translation = new Vector3(halfDistance, 0, 0);
                break;
            case Axis2D.Y:
                translation = new Vector3(0, halfDistance, 0);
                break;
        }
        childrenPositive.position = transform.position + translation;
        childrenNegative.position = transform.position - translation;
    }
}
