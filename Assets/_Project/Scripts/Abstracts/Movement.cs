using _Project.Scripts.Interfaces;
using UnityEngine;

namespace _Project.Scripts.Abstracts
{
    public abstract class Movement : MonoBehaviour, IMovable<Vector2>
    {
        [SerializeField] protected float _moveSpeed;
        [SerializeField] protected Rigidbody _rigidbody;
        [Tooltip("X is min value, Y is max value")]
        [SerializeField] protected Vector2 _clampPositionMinMax;

        #region Locomotion
        public virtual void Move(Vector2 moveInput)
        {
            float movement = moveInput.x;

            if (Mathf.Abs(movement) > 0.1f)
            {
                movement *= _moveSpeed * Time.deltaTime;
                Vector3 newPosition = transform.position + new Vector3(movement, 0f, 0f);
                newPosition.x = Mathf.Clamp(newPosition.x, _clampPositionMinMax.x, _clampPositionMinMax.y);
                _rigidbody.MovePosition(newPosition);
            }
        }

        #endregion
    }
}