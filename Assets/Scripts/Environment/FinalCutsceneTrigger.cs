using System.Collections;
using UnityEngine;

public class FinalCutsceneTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _finalCutscene;
    [SerializeField] private GameObject[] _gameplayAssets;
    [SerializeField] private GameObject _fadePanel;

    CutsceneTransitions _cutsceneTransitions;

    WaitForSeconds _fadeDelay = new WaitForSeconds(4f);


    void Start()
    {
        if(_fadePanel != null)
        {
            _fadePanel.GetComponent<CutsceneTransitions>();
        }
    }

    // When we collide with the trigger, start the final cutscene
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _finalCutscene.SetActive(true);
            Debug.Log("Starting Final Cutscene...");

            // Turn off all gameplay assets
            for (int i = 0; i < _gameplayAssets.Length; i++)
            {
                _gameplayAssets[i].SetActive(false);
            }
        }

        StartCoroutine(FadeDelayRoutine());
    }

    IEnumerator FadeDelayRoutine()
    {
        if(_cutsceneTransitions != null)
        {
            _cutsceneTransitions.FadeOut();
        }
        yield return _fadeDelay;
        Destroy(this.gameObject);
    }
}
