using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool isCinematicPlaying;
    [SerializeField] private bool isIdleCinematicPlaying;
    [SerializeField] private bool _startIdleTimer;

    [SerializeField] private float _idleTimer;
    private float _idleTimerRate = 10f;

    [SerializeField] private GameObject[] _cutscenes;

    [SerializeField] private GameObject introCutscene;
    [SerializeField] private GameObject[] gameplayObjects;
    [SerializeField] private GameObject[] _plasmaExplosions;



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
                //IsIdleCinematicPlaying = true;
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


    public void QuitProgram()
    {
        Application.Quit();
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGameplay()
    {
        Time.timeScale = 0f;
        introCutscene.SetActive(false);

        for (int i = 0; i < gameplayObjects.Length; i++)
        {
            gameplayObjects[i].SetActive(true);
        }
        for (int i = 0; i < _plasmaExplosions.Length; i++)
        {
            _plasmaExplosions[i].SetActive(true);
        }
    }
}
