using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class Bala : MonoBehaviour
    {
        public float cronometro;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            cronometro += Time.deltaTime;

            if(cronometro > 3)
            {
                gameObject.SetActive(false);
                cronometro = 0;
            }

            transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        }
    }
}
