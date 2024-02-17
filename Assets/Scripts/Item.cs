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
    [SerializeField] Button btn_buy;
    [SerializeField] Button btn_sell;
    // Start is called before the first frame update
    void Start()
    {
        Price_Txt.text = Price.ToString();
        Item_Image.texture = _texture;
    }

    public void Buy()
    {
        if (Transactions.instance.Buy(transform))
        {
            btn_buy.gameObject.SetActive(false);
            btn_sell.gameObject.SetActive(true);
            dropdown.gameObject.SetActive(true);
        }
    }
    public void Sell()
    {
        Transactions.instance.Sell(transform, dropdown.value);
        btn_buy.gameObject.SetActive(true);
        btn_sell.gameObject.SetActive(false);
        dropdown.gameObject.SetActive(false);
    }
}
