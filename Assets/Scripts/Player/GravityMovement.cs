using UnityEngine;
using UnityEngine.Events;

public class GravityMovement : MonoBehaviour
{
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private UnityEvent onJump;

    private Vector2 movement;
    private bool hasJumped = false;

    public void Jump()
    {
        if (!hasJumped)
            hasJumped = true;
    }

    public void Restart()
    {
        hasJumped = false;
        transform.position = Vector3.zero;
    }

    void Update()
    {
        if (hasJumped)
        {
            Debug.Log("Jumped");
            hasJumped = false;
            movement = Vector2.up * jumpForce;
            onJump.Invoke();
        }
        movement.y += gravity * Time.deltaTime;
        transform.position += (Vector3)movement * Time.deltaTime;    
    }
}
