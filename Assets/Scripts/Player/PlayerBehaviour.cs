using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int _currentCamera = 1;

    private PlayerCameraToggle _cameraToggle;

    private GameManager _gameManager;


    void Start()
    {
        _cameraToggle = GameObject.Find("Camera_Manager").GetComponent<PlayerCameraToggle>();
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        // If a cinematic is playing, don't allow the player to do anything
        if (_gameManager.IsCinematicPlaying) return;
        // Else, give them functionalty to change cameras and also initiate the idle custcene 
        else
        {
            SwitchCamera();

            // Continually gets called as the player keeps pressing buttons
            if (Input.anyKeyDown)
            {
                _gameManager.IdleCinematicIsPlaying();
            }
        }
    }

    void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_currentCamera == 1)
            {
                _currentCamera = 0;
            }
            else if (_currentCamera == 0)
            {
                _currentCamera = 1;
            }

            Debug.Log("I'm in!");
            _cameraToggle.SwitchCamera(_currentCamera);
        }
    }

    void Movement()
    {

    }
}
