using System.Collections;
using UnityEngine;

public class RedLightFlicker : MonoBehaviour
{
    [SerializeField] private GameObject[] _redLightPrefab;

    private WaitForSeconds _flickerTimer = new WaitForSeconds(0.5f);


    void Start()
    {
        StartCoroutine(RedLightFlickerRoutine());
    }


    IEnumerator RedLightFlickerRoutine()
    {
        while (true)
        {
            for (int i = 0; i < _redLightPrefab.Length; i++)
            {
                _redLightPrefab[i].SetActive(true);   
            }

            yield return _flickerTimer;

            for (int i = 0; i < _redLightPrefab.Length; i++)
            {
                _redLightPrefab[i].SetActive(false);
            }

            yield return _flickerTimer;
        }
    }
}
