using UnityEngine;
using NaughtyAttributes;

public class GapDistance : MonoBehaviour
{
    [SerializeField] private BoxCollider2DSize boxCollider2DSize;
    [SerializeField] private ChildrenDistance2D childrenDistance2D;
    public float distance;

    [Button]
    public void SetDistance()
    {
        // Set the size of the box collider.
        boxCollider2DSize.size = new Vector2(boxCollider2DSize.size.x, distance);
        boxCollider2DSize.SetSize();
        // Set the distance between the children.
        childrenDistance2D.distance = distance;
        childrenDistance2D.SetDistance();
    }

    void Start()
    {
        SetDistance();
    }
}
