using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class EnemyAnimationEvents : MonoBehaviour
    {
        EnemyOne enemyOne;


        private void Awake()
        {
            enemyOne = GetComponentInParent<EnemyOne>();
        }
        public void Final_Ani()
        {
            enemyOne.FinalAnim();
        }
    }
}
