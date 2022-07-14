using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent onEnemyTrigger;
    [SerializeField] private UnityEvent onScoreTrigger;

    private void OnTriggerEnter2D(Collider2D other) {
        switch (other.gameObject.tag) {
            case "Enemy":                
                onEnemyTrigger.Invoke();
                break;
            case "Score":
                onScoreTrigger.Invoke();
                break;
            default:
                Debug.LogWarning("Unknown Trigger");
                break;
        }
    }
}
