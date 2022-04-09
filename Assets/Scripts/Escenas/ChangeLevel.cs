using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EC
{
    public class ChangeLevel : MonoBehaviour
    {
        public bool changeLevel;
        public int levelIndex;
        void Start()
        {

        }

        void Update()
        {
         if(changeLevel)
            {
                HandleChangeLevel(levelIndex);
            }
        }

        public void HandleChangeLevel(int ind)
        {
            SceneManager.LoadScene(ind);
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Entro para ir");
            HandleChangeLevel(levelIndex);
        }
    }
}
