using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // there can only be one esconor the one game manager 
    public static GameManager instance;
    public List<DamageOnOverlap> damageZones;
    public Pawn player;

    [Header("Timer")]
    public float timeRemaining;
    public float maxTime;


    // So that the game result win/lose only plays onces
    private bool playGameResult = true;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

        // Start w/ 0 damage zones
        damageZones = new List<DamageOnOverlap>();
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set the timr to max time
        timeRemaining = maxTime;
    }

    public void ResetTimer()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damageZones.Count <= 0 && playGameResult)
        { 
            WinGame();
        }
        else if (player == null && playGameResult)
        {
            LoseGame();
        }
        
    }

    void WinGame()
    {
        Debug.Log("Great work Soldier!!!!");
        playGameResult = false; 
    }

    void LoseGame()
    {
        Debug.Log("Disapointing Failure!!!!");
        playGameResult = false;
    }
}
