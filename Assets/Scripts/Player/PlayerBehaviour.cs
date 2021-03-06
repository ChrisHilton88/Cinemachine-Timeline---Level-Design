using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int _currentCamera = 1;
    private float _speed = 50;
    private float _speedAdjuster = 0.5f;
    private float _rotSpeed = 25f;
    private int _maxSpeed = 100;
    private int _minSpeed = 50;

    private PlayerCameraToggle _cameraToggle;

    private GameManager _gameManager;

    private EngineEmissionChange _engineEmissionChange;

    private bool isCinematicPlaying = false;


    void Start()
    {
        _cameraToggle = GameObject.Find("Camera_Manager").GetComponent<PlayerCameraToggle>();
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
        _engineEmissionChange = GetComponentInChildren<EngineEmissionChange>();
    }

    void Update()
    {
        if (isCinematicPlaying) return;
        else
        {
            if (Time.timeScale == 0) return;
            else
            {
                Movement();
                SwitchCamera();
                ThrusterBoost();
            }

            // Starts timer if any input detected
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

            _cameraToggle.SwitchCamera(_currentCamera);
        }
    }

    void Movement()
    {
        //transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float _horizontalInput = Input.GetAxis("Horizontal");
        float _verticalInput = Input.GetAxis("Vertical");


        Vector3 rotateH = new Vector3(0, _horizontalInput, 0);
        transform.Rotate(rotateH * _rotSpeed * Time.deltaTime);

        Vector3 rotateV = new Vector3(_verticalInput, 0, 0);
        transform.Rotate(rotateV * _rotSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, 0, -_horizontalInput * 0.2f), Space.Self);

        transform.position += transform.forward * _speed * Time.deltaTime;

    }

    void ThrusterBoost()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed += _speedAdjuster;
            _engineEmissionChange.ThrusterIncrease();

            if(_speed >= _maxSpeed)
            {
                _speed = _maxSpeed;
            }
        }
        else
        {
            _speed -= _speedAdjuster;
            _engineEmissionChange.ThrusterIdle();

            if(_speed <= _minSpeed)
            {
                _speed = _minSpeed;
            }
        }
    }
}
