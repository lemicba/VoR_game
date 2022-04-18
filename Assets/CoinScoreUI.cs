using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace EC
{
    public class CoinScoreUI : MonoBehaviour
    {
        public TextMeshProUGUI textMesh;

        private void Start()
        {
            textMesh = GetComponent<TextMeshProUGUI>();
        }
        private void Update()
        {
            textMesh.text = GameManager.score.ToString();
        }
    }
}
