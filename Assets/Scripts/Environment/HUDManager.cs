using UnityEngine;
using Cinemachine;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _welcomeText;
    [SerializeField] private GameObject[] _switchCameraText;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _nextButton;
    [SerializeField] private GameObject _exitButton;
    [SerializeField] private CinemachineVirtualCamera _cockpitVCam;


    void Start()
    {
        Time.timeScale = 0f;
        _cockpitVCam = GameObject.Find("Gameplay_Cockpit_VCam").GetComponent<CinemachineVirtualCamera>();
        _cockpitVCam.m_Priority = 20;

        for (int i = 0; i < _switchCameraText.Length; i++)
        {
            _switchCameraText[i].SetActive(false);
        }

        _exitButton.SetActive(false);
    }

    public void ClickNextButton()
    {
        _nextButton.SetActive(false);
        _exitButton.SetActive(true);

        for (int i = 0; i < _welcomeText.Length; i++)
        {
            _welcomeText[i].SetActive(false);
        }

        for (int i = 0; i < _switchCameraText.Length; i++)
        {
            _switchCameraText[i].SetActive(true);
        }
    }

    public void ClickExitButton()
    {
        _canvas.SetActive(false);

        Time.timeScale = 1f;
    }
}
