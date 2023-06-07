using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.Blocks
{
    public class BlockStackManager : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _blockList;
        [SerializeField] private GameObject _lastBlock;

        private void Start()
        {
            UpdateInfoAboutLastBlock();
        }

        public void AddNewBlock(GameObject objectToAdd)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.38f, transform.position.z);
            objectToAdd.transform.SetParent(transform);
            objectToAdd.transform.position = new Vector3(transform.position.x, _lastBlock.transform.position.y - 0.38f,
                transform.position.z);
            _blockList.Add(objectToAdd);
            UpdateInfoAboutLastBlock();
        }

        public void DeleteObjectsFromStack(GameObject objectToDelete)
        {
            objectToDelete.transform.parent = null;
            _blockList.Remove(objectToDelete);
            UpdateInfoAboutLastBlock();
        }

        public void DeleteObjectsFromStack()
        {
            if (_lastBlock.GetComponent<BlockStackManager>())
            {
                print("GameOver");
                EventManager.instance.GameOver();
            }
            Transform temp = _blockList[_blockList.Count - 1].transform.parent = null;
            _blockList.Remove(temp.gameObject);
            UpdateInfoAboutLastBlock();
        }

        private void UpdateInfoAboutLastBlock()
        {
            _lastBlock = _blockList[_blockList.Count - 1];
        }
    }
}