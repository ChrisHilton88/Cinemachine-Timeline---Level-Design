using UnityEngine;

public class AIBehaviour : MonoBehaviour
{
    private int _speed = 50;


    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
