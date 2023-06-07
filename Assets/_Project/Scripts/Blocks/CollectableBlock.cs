using _Project.Scripts.Audio;
using UnityEngine;

namespace _Project.Scripts.Blocks
{
    public class CollectableBlock : MonoBehaviour
    {
        [SerializeField] private BlockStackManager _blockStackManager;
        [SerializeField] private bool isStacked;
        
        private Vector3 direct = Vector3.back;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<CollectableBlock>() != null
                || collision.gameObject.GetComponent<BlockStackManager>() != null)
            {
                Stack();
            }
        }

        private void Direction()
        {
            direct = Vector3.forward;
        }

        [ContextMenu("TestStack")]
        private void Stack()
        {
            if (!isStacked)
            {
                isStacked = true;
                _blockStackManager.AddNewBlock(gameObject);
                Direction();
                AudioManager.instance.PlaySfxAudio(3);
            }
        }
    }
}