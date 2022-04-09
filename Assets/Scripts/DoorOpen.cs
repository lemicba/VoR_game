using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class DoorOpen : MonoBehaviour
    {
        public Animator anim;

        private void OnEnable()
        {
            EventManager.OnDoorOpen += OnDoorOpenHandler;
        }

        private void OnDisable()
        {
            EventManager.OnDoorOpen -= OnDoorOpenHandler;
        }

        private void OnDoorOpenHandler()
        {
            anim.SetBool("isPress", true);
        }
    }
}
