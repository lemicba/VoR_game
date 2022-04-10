using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EC
{
    public class HitBoss : MonoBehaviour
    {
        public int damage;

        private void OnTriggerEnter(Collider coll)
        {
            if (coll.CompareTag("Player"))
            {
                coll.GetComponent<PlayerStats>().TakeDamage(damage);
            }
        }
    }
}
