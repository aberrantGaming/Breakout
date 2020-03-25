using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    class NoInput : InputProcessor
    {
        protected override void HandleMovement()
        {
            moveInput = Vector3.zero;

            base.HandleMovement();
        }
    }
}
