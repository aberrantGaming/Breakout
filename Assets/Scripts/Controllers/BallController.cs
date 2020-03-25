using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    public class BallController : UnitController
    {
        protected override void HandleCollision(Collision context)
        {
            Debug.DrawRay(context.contacts[0].point, context.contacts[0].normal, Color.red, 10f);

            var tempVect = Vector3.Reflect(this.transform.forward, context.contacts[0].normal);
            _rb.rotation = Quaternion.LookRotation(tempVect.normalized).normalized;
        }
    }
}