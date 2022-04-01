using UnityEngine;

public class ISSMovement : MonoBehaviour
{
    float speed = 0.5f;
    float rotSpeed = 0.5f;



    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Rotate(0, -rotSpeed * Time.deltaTime, 0, Space.World);
    }
}
