using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.UpdateTXTHealth(playerHealth);
    }

    public void UpdateHealth(float amount)
    {
        if (playerHealth > 0)
        {
            playerHealth -= amount;
            uiManager.UpdateTXTHealth(playerHealth);
            if (playerHealth <= 0)
            {
                Debug.Log("Respawn");
                SceneManager.LoadScene("Plataformas de madera");
            }
        }
        
    }
}
