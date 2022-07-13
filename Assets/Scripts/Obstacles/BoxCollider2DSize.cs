using UnityEngine;
using NaughtyAttributes;

[ExecuteInEditMode]
[RequireComponent(typeof(BoxCollider2D))]
public class BoxCollider2DSize : MonoBehaviour
{
    public Vector2 size = new Vector2(1, 1);
    private BoxCollider2D boxCollider2D;

    [Button]
    public void SetSize()
    {
        boxCollider2D.size = size;
    }

    void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
}
