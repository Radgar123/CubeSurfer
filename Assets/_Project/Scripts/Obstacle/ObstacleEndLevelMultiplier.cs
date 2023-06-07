using _Project.Scripts.Blocks;
using _Project.Scripts.Managers;
using UnityEngine;

namespace _Project.Scripts.Obstacle
{
    public class ObstacleEndLevelMultiplier : Obstacle
    {
        [SerializeField] private int _multiplier;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<CollectableBlock>() != null
                || collision.gameObject.GetComponent<BlockStackManager>() != null)
            {
                GameManager.instance.multiplier = _multiplier;
                Interact(collision.gameObject);
            }
        }
    }
}