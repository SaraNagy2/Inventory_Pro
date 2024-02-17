using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transactions : MonoBehaviour
{
    public static Transactions instance;
    [SerializeField] Transform Content_shopkeeper_1;
    [SerializeField] Transform Content_shopkeeper_2;
    [SerializeField] Transform Content_MyItems;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    public void Buy(Transform item)
    {
        Item _item = item.GetComponent<Item>();
        if (ATM.instance.Coin_Balance - _item.Price >= 0)
        {
            ATM.instance.Coin_Balance -= _item.Price;
            ATM.instance.SetBalance();
            item.SetParent(Content_MyItems);
        }
    }
    public void Sell(Transform item,int shopkeeperNum)
    {
        Item _item = item.GetComponent<Item>();
        ATM.instance.Coin_Balance += _item.Price;
        ATM.instance.SetBalance();
        if (shopkeeperNum == 0)
        {
            item.SetParent(Content_shopkeeper_1);
        }
        else if(shopkeeperNum ==1)
        {
            item.SetParent(Content_shopkeeper_2);
        }
    }
}
