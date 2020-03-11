using UnityEngine;

namespace aberrantGaming.Breakout
{
    class SimpleInput : InputProcessor
    {
        protected override void HandleInput()
        {
            moveInput = transform.forward;

            base.HandleInput();
        }
    }
}
