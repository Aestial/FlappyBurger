using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SkinImage : MonoBehaviour
{
    private Image image;
    private Color color;

    public Color Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
            image.color = color;
        }
    }

    void Awake()
    {
        image = GetComponent<Image>();
    }
}
