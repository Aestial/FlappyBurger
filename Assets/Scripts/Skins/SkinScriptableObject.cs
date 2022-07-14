using UnityEngine;

[CreateAssetMenu(fileName = "NewSkinTheme", menuName = "Skin Theme", order = 0)]
public class SkinScriptableObject : ScriptableObject 
{    
    public Sprite background;
    public Color backgroundColor;
    public Color buttonsColor;
    public Color cameraColor;
}