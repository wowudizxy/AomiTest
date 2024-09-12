using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private Image colorSprite;
    public void SetSprite(Sprite sprite)
    {
        colorSprite.sprite = sprite;
    }
    public void SetID(int id)
    {
        idText.text = "ID: "+id.ToString();
    }
}
