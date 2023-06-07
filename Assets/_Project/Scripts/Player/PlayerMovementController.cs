using System;
using _Project.Scripts.Abstracts;
using UnityEngine;

namespace _Project.Scripts.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovementController : Movement
    {
        [SerializeField] private float _runSpeed;
        public bool isStillRun;
        
        private void Awake()
        {
            if (_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
            
            EventManager.instance.startGame.AddListener(StartRun);
            EventManager.instance.gameOver.AddListener(StopRun);
        }

        private void FixedUpdate()
        {
            Run();
        }

        #region Locomotion

        public override void Move(Vector2 moveInput)
        {
            Debug.Log("Player Is Move");
            base.Move(moveInput);
        }

        private void Run()
        {
            if (isStillRun)
            {
                _rigidbody.AddForce(transform.forward * _runSpeed,ForceMode.VelocityChange);
            }
        }
        #endregion

        #region VariableChanges

        public void StartRun()
        {
            isStillRun = true;
        }

        private void StopRun()
        {
            isStillRun = false;
        }

        #endregion

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<Coin.Coin>() != null)
            {
                collision.gameObject.GetComponent<Coin.Coin>().Interact(collision.gameObject);
            }
        }
    }
}