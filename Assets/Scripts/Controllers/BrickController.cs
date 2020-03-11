using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    class BrickController : UnitController
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log($"Collision with {collision.gameObject.name}");

            if (collision.gameObject.GetComponent<BallController>() is null)
                return;

            Destroy(this.gameObject);
        }
    }
}
