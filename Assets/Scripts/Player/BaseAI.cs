using UnityEngine;

public abstract class BaseAI : MonoBehaviour
{
    protected string health;
    protected string shipName;

    protected abstract void PlayerMove();
    protected abstract void Shoot();
}
