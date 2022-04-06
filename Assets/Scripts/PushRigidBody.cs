using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class PushRigidBody : MonoBehaviour
    {

        private float targetMass;
        public float pushPower = 2.0f;

        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            Rigidbody body = hit.collider.attachedRigidbody;

            if (body == null || body.isKinematic)
                return;

            if (hit.moveDirection.y < -0.3)
                return;

            targetMass = body.mass;

            Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

            body.velocity = pushDirection * pushPower / targetMass;
        }
    }
}
