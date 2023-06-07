using System;
using UnityEngine;

namespace _Project.Scripts.Player
{
    public class PlayerAnimationController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void OnEnable()
        {
            EventManager.instance.startGame.AddListener(EnableRun);
            EventManager.instance.gameOver.AddListener(EnableIdle);
        }

        private void OnDisable()
        {
            EventManager.instance.startGame.RemoveListener(EnableRun);
            EventManager.instance.gameOver.RemoveListener(EnableIdle);
        }

        /*private void Start()
        {
            EventManager.instance.startGame.AddListener(EnableRun);
            EventManager.instance.gameOver.AddListener(EnableIdle);
        }*/

        #region Change Animation Status

        private void EnableRun(){_animator.SetBool("IsRun",true);}

        private void EnableIdle(){ _animator.SetBool("IsRun", false); }

        #endregion
    }
}