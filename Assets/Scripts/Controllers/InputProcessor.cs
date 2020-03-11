using UnityEngine;

namespace aberrantGaming.Breakout
{
    public abstract class InputProcessor : MonoBehaviour
    {
        protected UnitController controller;
        protected Vector3 moveInput = Vector3.zero;
        
        protected virtual void Start()
        {
            controller = GetComponent<UnitController>();

            if (!(controller is null))
                controller.Initialize();
        }

        protected virtual void LateUpdate()
        {
            if (controller is null)
                return;

            if (!controller.MovementLocked)
            {
                HandleInput();
            }
        }

        protected virtual void FixedUpdate()
        {
            if (controller is null)
                return;

            controller.UpdateMotor();
        }

        protected virtual void HandleInput()
        {
            controller._input = new Vector2(moveInput.x, moveInput.z);
        }
    }
}
