using System;
using System.Collections.Generic;
using _Project.Scripts.Interfaces;
using _Project.Scripts.Coin;
using UnityEngine;

namespace _Project.Scripts.Controllers
{
    public class RotateCoinControllers : MonoBehaviour, IRotateable
    {
        [SerializeField] private List<GameObject> _coins;
        [SerializeField] private float _rotateSpeed = 1f;

        private void Update()
        {
            Rotate();
        }

        public void Rotate()
        {
            foreach (var obj in _coins)
            {
                obj.transform.Rotate(Vector3.left,_rotateSpeed * Time.deltaTime);
            }
        }
    }
}