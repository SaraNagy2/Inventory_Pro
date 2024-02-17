using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ATM : MonoBehaviour
{
    public static ATM instance;

    [SerializeField] TextMeshProUGUI Coin_Balance_Txt;
    [SerializeField] TextMeshProUGUI Bank_Balance_Txt;
    [SerializeField] TMP_InputField Amount_Txt;
    public int Coin_Balance = 1000;
    public int Bank_Balance = 3000;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

    }
    void Start()
    {
        SetBalance();
    }

    public void SetBalance() 
    {
        Coin_Balance_Txt.text = Coin_Balance.ToString();
        Bank_Balance_Txt.text = Bank_Balance.ToString();
    }

    public void Withdraw()
    {
        int Amount = 0;
        int.TryParse(Amount_Txt.text,out Amount);

        if (Amount>0 && Bank_Balance - Amount >= 0)
        {
            Bank_Balance -= Amount;
            Coin_Balance += Amount;
            SetBalance();
        }
    }

    public void Deposit()
    {
        int Amount = 0;
        int.TryParse(Amount_Txt.text, out Amount);

        if (Amount > 0 && Coin_Balance - Amount >= 0)
        {
            Coin_Balance -= Amount;
            Bank_Balance += Amount;
            SetBalance();
        }
    }

}
