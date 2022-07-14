using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSystem : MonoBehaviour
{
    [SerializeField] private SkinScriptableObject[] skins;
    [SerializeField] private int currentSkinIndex;
    [SerializeField] private bool isRandomSkin;

    [SerializeField] private SkinSprite background;
    private SkinImage[] skinImages;

    public void SetSkin(int index)
    {
        currentSkinIndex = index;
        PlayerPrefs.SetInt("Skin", index);
        UpdateSkin(index);
    }

    void Awake()
    {
        skinImages = FindObjectsOfType<SkinImage>();
    }
    
    void Start()
    {
        int skinIndex;
        
        if (PlayerPrefs.HasKey("Skin"))
        {
            skinIndex = PlayerPrefs.GetInt("Skin");
        }
        else if (isRandomSkin)
        {
            skinIndex = Random.Range(0, skins.Length);
        }
        else
        {
            skinIndex = currentSkinIndex;
        }
        UpdateSkin(skinIndex);
    }
    
    private void UpdateSkin(int index)
    {
        // Background
        background.Sprite = skins[index].background;
        background.Color = skins[index].backgroundColor;
        // Camera
        Camera.main.backgroundColor = skins[index].cameraColor;
        // Buttons
        foreach (SkinImage skinImage in skinImages)
        {
            skinImage.Color = skins[index].buttonsColor;
        }
    }
}
