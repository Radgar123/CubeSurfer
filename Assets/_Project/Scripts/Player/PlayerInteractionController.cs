using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.Player
{
    public class PlayerInteractionController : MonoBehaviour
    {
        [Header("Stack Block")] [SerializeField]
        private List<GameObject> _stackedBlocks;
    }
}