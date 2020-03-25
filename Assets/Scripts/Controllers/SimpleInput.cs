using UnityEngine;

namespace aberrantGaming.Breakout
{
    class SimpleInput : InputProcessor
    {
        protected override void HandleMovement()
        {
            moveInput = transform.forward;

            base.HandleMovement();
        }
    }
}
