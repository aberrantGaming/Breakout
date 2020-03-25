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
        protected override void HandleCollision(Collision context)
        {
            if (context.gameObject.GetComponent<BallController>() is null)
                return;

            Destroy(this.gameObject);
        }
    }
}
