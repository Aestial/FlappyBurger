using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SkinSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color color;
    private Sprite sprite;

    public Color Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
            spriteRenderer.color = color;
        }
    }
    public Sprite Sprite
    {
        get
        {
            return sprite;
        }
        set
        {
            sprite = value;
            spriteRenderer.sprite = sprite;
        }
    }
    
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
