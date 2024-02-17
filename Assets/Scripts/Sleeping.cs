using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeping : MonoBehaviour
{
    [SerializeField] GameObject Sleeping_Block;
    [SerializeField] float SleepingTime = 3.0f;
    public void sleep() 
    {

        StartCoroutine(WaitSleeping(SleepingTime));
    }

    IEnumerator WaitSleeping(float waitTime)
    {
        Sleeping_Block.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        Sleeping_Block.SetActive(false);
        ATM.instance.Bank_Balance += (int)(ATM.instance.Bank_Balance * 0.1f);
        ATM.instance.SetBalance();
    }
}
