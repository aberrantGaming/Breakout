using UnityEngine;
using UnityEngine.InputSystem;

namespace aberrantGaming.Breakout
{
    class PaddleInput : InputProcessor
    {
        private InputAction movementInput;
        private InputAction interactionInput;

        [SerializeField]
        private InputActionAsset controls;

        private void OnEnable()
        {
            var actionMap = controls.FindActionMap("Gameplay");

            movementInput = actionMap.FindAction("Movement");
            movementInput.started += HandleInput;
            movementInput.canceled += HaltInput => moveInput = Vector2.zero;
            movementInput.Enable();

            interactionInput = actionMap.FindAction("Interact");
            interactionInput.performed += HandleInteract;
            interactionInput.Enable();
        }

        private void HandleInput(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
        }

        private void HandleInteract(InputAction.CallbackContext context)
        {
            Debug.Log("Interacting..");
        }
    }
}
