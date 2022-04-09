using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class EnemyOne : MonoBehaviour
    {

        public int routine;
        public float chronometer;
        public Animator ani;
        public Quaternion angle;
        public float grade;
        public int life;
        public bool pressBtn;
        public bool atacando;
        EnemyStats enemyStats;

        public GameObject target;
        private void Start()
        {
            ani = GetComponentInChildren<Animator>();
            target = GameObject.Find("Player");
            enemyStats = GetComponent<EnemyStats>();
        }
        void Update()
        {
            EnemyBehavior();
            if (pressBtn)
            {
                enemyStats.TakeDamage(25);
            }
        }

        public void EnemyBehavior()
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 5)
            {
                chronometer += 1 * Time.deltaTime;
                if (chronometer >= 4)
                {
                    routine = Random.Range(0, 2);
                    chronometer = 0;
                }
                switch (routine)
                {
                    case 0:
                        ani.SetBool("running", false);
                        break;
                    case 1:
                        grade = Random.Range(0, 360);
                        angle = Quaternion.Euler(0, grade, 0);
                        routine++;
                        break;
                    case 2:
                        transform.rotation = Quaternion.RotateTowards(transform.rotation, angle, 0.5f);
                        transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                        ani.SetBool("running", true);
                        break;
                }
            }
            else
            {
                if(Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando) { 
                    var lookPos = target.transform.position - transform.position;
                    lookPos.y = 0;
                    var rotation = Quaternion.LookRotation(lookPos);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
                    ani.SetBool("running", true);
                    transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                    ani.SetBool("attack", false);
                }
                else
                {
                    ani.SetBool("running", false);

                    ani.SetBool("attack", true);
                    atacando = true;
                }
            }
        }

        public void FinalAnim()
        {
            ani.SetBool("attack", false);
            atacando = false;
        }
    }
}