using System;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    public class UnitController : UnitMotor
    {
        private void OnCollisionEnter(Collision collision)
        {
            HandleCollision(collision);
        }

        private void HandleCollision(Collision collision)
        {
            var tempVect = Vector3.Reflect(this.transform.forward, collision.contacts[0].normal);  
            
            _rb.rotation = Quaternion.LookRotation(tempVect.normalized).normalized;

            Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.red, 10f);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawRay(this.transform.position, this.transform.forward);
        }
    }
}
