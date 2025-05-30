using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    
    public void UpdateMoney(float amount){
        playerMoney += amount;

        if (playerMoney + amount < 0){
            //impedir compra
        } else {
            playerMoney += amount;
        }
    }
}
