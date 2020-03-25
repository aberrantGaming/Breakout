using System;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    public abstract class UnitController : UnitMotor
    {
        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawRay(this.transform.position, this.transform.forward);
        }

        private void OnCollisionEnter(Collision collision)
        {            
            Debug.Log($"{gameObject.name} collided with {collision.gameObject.name}");

            HandleCollision(collision);
        }

        protected virtual void HandleCollision(Collision context)
        {

        }
    }
}
