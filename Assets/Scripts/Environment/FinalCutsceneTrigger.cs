using UnityEngine;

public class FinalCutsceneTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _finalCutscene;
    [SerializeField] private GameObject[] _gameplayAssets;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _finalCutscene.SetActive(true);
            Debug.Log("Starting Final Cutscene...");

            for (int i = 0; i < _gameplayAssets.Length; i++)
            {
                _gameplayAssets[i].SetActive(false);
            }
        }
    }
}
