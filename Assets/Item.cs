using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Price_Txt;
    [SerializeField] RawImage Item_Image;
    public int Price;
    [SerializeField] Texture _texture;

    // Start is called before the first frame update
    void Start()
    {
        Price_Txt.text = Price.ToString();
        Item_Image.texture = _texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
