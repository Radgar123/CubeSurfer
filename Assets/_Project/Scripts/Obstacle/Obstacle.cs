using _Project.Scripts.Blocks;
using _Project.Scripts.Interfaces;
using Unity.VisualScripting;
using UnityEngine;

namespace _Project.Scripts.Obstacle
{
    public abstract class Obstacle : MonoBehaviour, IInteractable<GameObject>
    {
        [SerializeField] protected BlockStackManager _blockStackManager;
        [SerializeField] protected bool isUse;
        public virtual void Interact(GameObject parameter)
        {
            if (!isUse)
            {
                isUse = true;
                _blockStackManager.DeleteObjectsFromStack();
            }
        }
    }
}