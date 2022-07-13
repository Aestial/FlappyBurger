using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float delay = 0.0f;
    [SerializeField] private float repeatRate = 0.1f;
    private SpriteRenderer spriteRenderer;
    private int currentFrame;

    public void SetFrame(int frame)
    {
        currentFrame = frame;
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("Animate", delay, repeatRate);
    }

    private void Animate()
    {
        spriteRenderer.sprite = sprites[currentFrame];
        currentFrame++;
        if (currentFrame >= sprites.Length) currentFrame = 0;
    }
}
