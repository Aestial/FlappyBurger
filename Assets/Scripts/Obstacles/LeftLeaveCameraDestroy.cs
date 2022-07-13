using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLeaveCameraDestroy : MonoBehaviour
{
    [SerializeField] private float destroyOffset = 1f;
    private float leftBorder;

    void Start()
    {
        leftBorder = Camera.main.ScreenToWorldPoint(Vector3.zero).x - destroyOffset;
    }

    void Update()
    {
        if (transform.position.x < leftBorder)
        {
            Destroy(gameObject);
        }
    }
}
