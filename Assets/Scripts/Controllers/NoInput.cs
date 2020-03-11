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
        protected override void HandleInput()
        {
            moveInput = Vector3.zero;

            base.HandleInput();
        }
    }
}
