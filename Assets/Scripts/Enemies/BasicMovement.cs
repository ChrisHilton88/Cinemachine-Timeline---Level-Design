using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private int speed;
    private float yAngle = 0.025f;


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.left, yAngle, Space.Self);
    }
}
