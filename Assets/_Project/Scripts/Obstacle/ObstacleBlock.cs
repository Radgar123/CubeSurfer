using System;
using _Project.Scripts.Blocks;
using UnityEngine;

namespace _Project.Scripts.Obstacle
{
    public class ObstacleBlock : Obstacle
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<CollectableBlock>() != null
                || collision.gameObject.GetComponent<BlockStackManager>() != null)
            {
                Debug.Log("BLOCK " + collision.gameObject.name);
                Interact(collision.gameObject);
            }
        }
    }
}