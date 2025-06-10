using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text moneyText;
    float Money;

    public TMP_Text healthText;
    float Health;

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Plata: " + Money.ToString();
        healthText.text = "Salud: " + Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateTXTMoney(float money)
    {
        Money = money;
        moneyText.text = "Plata: " + Money.ToString();
    }

    public void UpdateTXTHealth(float health)
    {
        Health = health;
        healthText.text = "Salud: " + Health.ToString();
    }
}
