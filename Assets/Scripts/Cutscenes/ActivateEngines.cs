using UnityEngine;

public class ActivateEngines : MonoBehaviour
{
    [SerializeField] private GameObject[] _enginePrefab;



    public void TurnEnginesOn()
    {
        for (int i = 0; i < _enginePrefab.Length; i++)
        {
            _enginePrefab[i].SetActive(true);
        }

        Debug.Log("Activated: " + gameObject.name + " engines!");
    }
}
