using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class FallingDie : MonoBehaviour
    {
        PlayerStats playerStats;

        private void Awake()
        {
            playerStats = GetComponent<PlayerStats>();
        }
        private void OnTriggerEnter(Collider other)
        {
            playerStats.TakeDamage(5000);
            Debug.Log("muere");
        }
    }
}
