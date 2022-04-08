using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool isCinematicPlaying;
    [SerializeField] private bool isIdleCinematicPlaying;
    [SerializeField] private bool _startIdleTimer;

    [SerializeField] private float _idleTimer;
    private float _idleTimerRate = 10f;

    [SerializeField] private GameObject _idleCutscene;


    void Start()
    {
        _idleCutscene.SetActive(false);
    }

    // intro and final cutscene property trigger
    public bool IsCinematicPlaying
    {
        get
        {
            return isCinematicPlaying;
        }
        set
        {
            isCinematicPlaying = value;
        }
    }

    // idle cutscene trigger
    public bool IsIdleCinematicPlaying
    {
        get
        {
            return isIdleCinematicPlaying;
        }
        set
        {
            isIdleCinematicPlaying = value;
        }
    }


    public void CinematicIsPlaying()
    {
        if (IsCinematicPlaying)
        {
            IsCinematicPlaying = !IsCinematicPlaying;
            Debug.Log("Cinematic is NOT playing");

        }
        else
        {
            IsCinematicPlaying = true;
            Debug.Log("Cinematic is playing");
        }
    }

    public void IdleCinematicIsPlaying()
    {
        _idleTimer = Time.time;
        _startIdleTimer = true;
        Debug.Log("_startIdleTimer = true");

        // If timer bool true
        if (_startIdleTimer)
        {

            // Will never get called 
            if ((_idleTimer + _idleTimerRate) < Time.time)
            {
                // Turn idle cutscene ON. Play on Awake
                _idleCutscene.SetActive(true);
                IsIdleCinematicPlaying = true;
                _startIdleTimer = false;
                Debug.Log("_startIdleTimer = false");
            }
        }

        if (isIdleCinematicPlaying)
        {
            isIdleCinematicPlaying = !isIdleCinematicPlaying;
            Debug.Log("Idle Cinematic is NOT playing");
        }
        else
        {
            isIdleCinematicPlaying = true;
            Debug.Log("Idle Cinematic is playing");
        }
    }





    void QuitAppliation()
    {
        Application.Quit();
    }
}
