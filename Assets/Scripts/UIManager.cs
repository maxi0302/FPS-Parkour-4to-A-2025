using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text moneyText;
    float Money;

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Plata: " + Money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateUI(float money)
    {
        Money = money;
        moneyText.text = "Plata: " + Money.ToString();
    }
}
