using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameSession : MonoBehaviour
{
    private int score = 0;
    [SerializeField] List<AudioSource> sfClips;

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
            foreach (var audioSource in sfClips)
            {
                Destroy(audioSource);
            }
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            foreach (var audioSource in sfClips)
            {
                DontDestroyOnLoad(audioSource);
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void PlayRandomSound()
    {
        sfClips[Random.Range(0, sfClips.Count)].Play();
    }
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }


    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
