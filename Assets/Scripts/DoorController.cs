using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EC
{
    public class DoorController : MonoBehaviour
    {
        public Animator anim;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                EventManager.TriggerOnDoorOpen();
            }
        }
    }
}