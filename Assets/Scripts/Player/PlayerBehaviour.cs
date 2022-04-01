using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int _currentCamera = 1;

    private bool isCinematicPlaying;

    private PlayerCameraToggle _cameraToggle;



    void Start()
    {
        _cameraToggle = GameObject.Find("Camera_Manager").GetComponent<PlayerCameraToggle>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !isCinematicPlaying)
        {
            if (_currentCamera == 1)
            {
                _currentCamera = 0;
            }
            else if (_currentCamera == 0)
            {
                _currentCamera = 1;
            }

            _cameraToggle.ResetCams();
            _cameraToggle.SetPriorítyCamera(_currentCamera);
        }
    }

    void Movement()
    {

    }
}
