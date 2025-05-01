using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private int coinAmountAtStart;
    [SerializeField] private TMP_Text coinAmount;

    public static int currentCoinAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        currentCoinAmount = coinAmountAtStart;
    }

    // Update is called once per frame
    void Update()
    {
        coinAmount.text = currentCoinAmount.ToString();
    }
}
