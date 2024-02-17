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
    [SerializeField] TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        Price_Txt.text = Price.ToString();
        Item_Image.texture = _texture;
    }

    public void Buy()
    {
        Transactions.instance.Buy(transform);
    }
    public void Sell()
    {
        Transactions.instance.Sell(transform, dropdown.value);
    }
}
