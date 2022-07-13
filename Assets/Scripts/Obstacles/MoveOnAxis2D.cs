using UnityEngine;

/// <summary>
/// MoveOnAxis is a script that moves owner GameObject on the specified axis.
/// </summary>
public class MoveOnAxis2D : MonoBehaviour
{
    [SerializeField] Axis2D axis;
    [SerializeField] float speed = 2.0f;

    void Update()
    {
        switch (axis)
        {
            case Axis2D.X:
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                break;
            case Axis2D.Y:
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                break;
            default:
                break;
        }
    }
}
