using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI _moneyText;
    public int _moneyAmount = 1000;

    // Start is called before the first frame update
    void Start()
    {
        _moneyText.text = _moneyAmount.ToString();
    }

    public void SpendMoney(int moneySpent) //el item tendr� una variable que sera el coste, y eso ser� lo que se le pasar� por aqu�
    {
        _moneyAmount -= moneySpent;

        _moneyText.text = _moneyAmount.ToString();
    }

    public void EarnMoney(int moneyEarned)
    {
        _moneyAmount += moneyEarned;

        _moneyText.text = _moneyAmount.ToString();
    }
}
