using UnityEngine;

public class EngineEmissionChange : MonoBehaviour
{
    private int _thrusterIdle = 1;
    private int _thrusterBoost = 50;

    ParticleSystem.EmissionModule _engineEmission;

    void Start()
    {
        ParticleSystem _ps = GetComponent<ParticleSystem>();
        _engineEmission = _ps.emission;
        _engineEmission.rateOverTime = _thrusterIdle;
    }

    public void ThrusterIncrease()
    {
        _engineEmission.rateOverTime = _thrusterBoost;
        Debug.Log(_engineEmission.rateOverTime.constantMax);
    }

    public void ThrusterIdle()
    {
        _engineEmission.rateOverTime = _thrusterIdle;
        Debug.Log(_engineEmission.rateOverTime.constantMax);
    }
}
