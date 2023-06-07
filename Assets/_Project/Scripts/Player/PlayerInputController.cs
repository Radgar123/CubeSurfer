using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project.Scripts.Player
{
    [RequireComponent(typeof(PlayerMovementController))]
    public class PlayerInputController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementController _playerMovementController;
        private void Awake()
        {
            if (_playerMovementController == null)
            {
                _playerMovementController = GetComponent<PlayerMovementController>();
            }
        }
        
        public void OnMouseChangePosMove(InputAction.CallbackContext context)
        {
            if (_playerMovementController.isStillRun)
            {
                Vector2 mousePosition = context.ReadValue<Vector2>();
                Vector2 moveInput = new Vector2(mousePosition.x, 0f);
                _playerMovementController.Move(moveInput);
            }
        }
    }
}