using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace EC { 
    public class EventManager : MonoBehaviour
    {
        public static event Action OnDoorOpen;
        public static event Action OnGameOver;
        public static event Action OnCollectCoins;

        public static void TriggerOnDoorOpen()
        {
            OnDoorOpen.Invoke();
        }
        public static void TriggerGameOver()
        {
            OnGameOver.Invoke();
        }
        public static void TriggerCollectCoins()
        {
            OnCollectCoins.Invoke();
            GameManager.scorePlayer();
        }
    }
}
