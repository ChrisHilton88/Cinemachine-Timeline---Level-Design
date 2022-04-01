using UnityEngine;

public class PlayerCameraToggle : MonoBehaviour
{
    [SerializeField] private GameObject[] _vCams;


    public void SwitchCamera(int currentCamera)
    {
        switch (currentCamera)
        {
            case 0:
                _vCams[currentCamera].gameObject.SetActive(true);
                _vCams[currentCamera + 1].gameObject.SetActive(false);
                break;
            case 1:
                _vCams[currentCamera].gameObject.SetActive(true);
                _vCams[currentCamera - 1].gameObject.SetActive(false);
                break;
        }
    }
}



// Alternative way of resetting and setting priorities
//public void SetPriorítyCamera(int currentCam)
//{
//    if (_vCams[currentCam].GetComponent<CinemachineVirtualCamera>())
//    {
//        _vCams[currentCam].GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
//    }
//}
//public void ResetCams()
//{
//    for (int i = 0; i < _vCams.Length; i++)
//    {
//        if (_vCams[i].GetComponent<CinemachineVirtualCamera>())
//        {
//            _vCams[i].GetComponent<CinemachineVirtualCamera>().m_Priority = 10;
//            Debug.Log("Successfully reset VCams priorities back to 10");
//        }
//    }
//}
