using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class EnemyStats : MonoBehaviour
    {
        public int healthLevel = 25;
        public int maxHealth;
        public int currentHealth;
        CapsuleCollider m_Collider;

        Animator animator;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            
        }
        void Start()
        {
            maxHealth = SetMaxHealthLevel();
            currentHealth = maxHealth;
            m_Collider = GetComponentInChildren<CapsuleCollider>();
        }

        private int SetMaxHealthLevel()
        {
            maxHealth = healthLevel;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            animator.Play("Damage_01");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Dead_01");
                m_Collider.enabled = !m_Collider.enabled;
            }
        }
    }
}