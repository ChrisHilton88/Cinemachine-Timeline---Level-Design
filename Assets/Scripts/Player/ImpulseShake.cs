using UnityEngine;  
using Cinemachine;

public class ImpulseShake : MonoBehaviour
{
    CinemachineImpulseSource _impSource;

    // Start is called before the first frame update
    void Start()
    {
        _impSource = GetComponent<CinemachineImpulseSource>();
    }


    public void Shake()
    {
        _impSource.GenerateImpulse();
        Debug.Log("Generated Impulse");
    }
}
