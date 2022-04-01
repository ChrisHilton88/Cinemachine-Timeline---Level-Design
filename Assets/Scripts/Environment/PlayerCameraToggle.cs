using UnityEngine;
using Cinemachine;

public class PlayerCameraToggle : MonoBehaviour
{
    [SerializeField] private GameObject[] _vCams;

    private int _currentVCam;


    public void SetPriorítyCamera(int currentCam)
    {
        if (_vCams[currentCam].GetComponent<CinemachineVirtualCamera>())
        {
            _vCams[currentCam].GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
        }
    }

    public void ResetCams()
    {
        for (int i = 0; i < _vCams.Length; i++)
        {
            if (_vCams[i].GetComponent<CinemachineVirtualCamera>())
            {
                _vCams[i].GetComponent<CinemachineVirtualCamera>().m_Priority = 10;
                Debug.Log("Successfully reset VCams priorities back to 10");
            }
        }
    }
}
