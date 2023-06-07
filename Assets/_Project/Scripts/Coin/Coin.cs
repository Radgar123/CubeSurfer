using _Project.Scripts.Audio;
using _Project.Scripts.Interfaces;
using _Project.Scripts.Managers;
using UnityEngine;

namespace _Project.Scripts.Coin
{
    public class Coin : MonoBehaviour, IInteractable<GameObject>
    {
        [SerializeField] private int _numberOfPointsToAdd;
        
        public void Interact(GameObject parameter)
        {
            GameManager.instance.numberOfColectedCoins += _numberOfPointsToAdd;
            AudioManager.instance.PlaySfxAudio(2);
            parameter.gameObject.SetActive(false);
        }
    }
}