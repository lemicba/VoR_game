using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace EC
{
    public class CoinInteract : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                EventManager.TriggerCollectCoins();
                Destroy(gameObject);
            }
        }

        private void OnEnable()
        {
            EventManager.OnCollectCoins += OnCollectCoinsHandler;
        }

        private void OnDisable()
        {
            EventManager.OnCollectCoins -= OnCollectCoinsHandler;
        }

        private void OnCollectCoinsHandler()
        {
            Debug.Log("coins handler");
        }

    }
}
