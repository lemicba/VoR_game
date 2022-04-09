using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EC
{
    public class PickUpGem : Interactable
    {
        public string messageInUI;

        public override void Interact(PlayerManager playerManager)
        {
            base.Interact(playerManager);

            PickUpGemHandler(playerManager);
        }

        private void PickUpGemHandler(PlayerManager playerManager)
        {
            PlayerLocomotion playerLocomotion;
            AnimatorHandler animatorHandler;

            playerLocomotion = playerManager.GetComponent<PlayerLocomotion>();
            animatorHandler = playerManager.GetComponentInChildren<AnimatorHandler>();

            playerLocomotion.rigidbody.velocity = Vector3.zero;
            animatorHandler.PlayTargetAnimation("Pick Up Item", true);
            playerManager.itemIteractableGameObject.GetComponentInChildren<Text>().text = messageInUI;
            playerManager.itemIteractableGameObject.SetActive(true);
            Destroy(gameObject);

        }
    }
}