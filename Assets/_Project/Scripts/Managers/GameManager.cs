using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public int numberOfColectedCoins;
        public int multiplier = 1;
        public int endPoints;
        public int GetEndPoints
        {
            protected set{}
            get { return numberOfColectedCoins * multiplier; }
        }
        public bool isDuringGame;

        private void Awake()
        {
            endPoints = GetEndPoints;
            //global::EventManager.instance.gameOver.AddListener(GetEndPoints);
        }
        
        //private void Game
    }
}

