using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Scripts.Audio
{
    public class AudioManager : Singleton<AudioManager>
    {
        [Header("Audio Source")]
        [SerializeField] private AudioSource _mainSource;
        [SerializeField] private AudioSource _sfxSource;
        
        [SerializeField] private AudioClip[] _mainAudioClips;
        [SerializeField] private AudioClip[] _sfxAudioClips;

        private void Awake()
        {
            //EventManager.instance.gameOver.AddListener(AudioOnGameOver);
        }

        private void Start()
        {
            int id = Random.Range(0, _mainAudioClips.Length);
            PlayMainAudioClip(id);
        }


        private void PlayMainAudioClip(int id)
        {
            _mainSource.clip = _mainAudioClips[id];
            _mainSource.Play();
        }

        public void PlaySfxAudio(int id)
        {
            _sfxSource.clip = _sfxAudioClips[id];
            _sfxSource.Play();
        }
        
        private void AudioOnGameOver(){PlaySfxAudio(1);}
    }
}