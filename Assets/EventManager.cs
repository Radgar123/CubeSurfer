using System.Collections;
using System.Collections.Generic;
using _Project.Scripts;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : Singleton<EventManager>
{
    [HideInInspector] public UnityEvent gameOver;
    [HideInInspector] public UnityEvent startGame;
    public void GameOver(){gameOver.Invoke();}
    public void StartGame(){startGame.Invoke();}
}
