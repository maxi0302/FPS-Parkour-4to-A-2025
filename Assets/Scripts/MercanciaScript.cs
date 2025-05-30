using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int price;
    public DineroManager dineroManager;

    void Start(){
        dineroManager = FindObjectOfType<DineroManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dineroManager.UpdateMoney(price);
            Destroy(gameObject);

        }
    }
}
