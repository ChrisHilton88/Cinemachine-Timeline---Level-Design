using UnityEngine;

public class IKPuppet : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private Animator _anim;

    float weight = 0.25f;

    private bool _pushedButton;


    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        _anim.SetIKPosition(AvatarIKGoal.RightHand, _target.transform.position);
        _anim.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);

    }

    void Update()
    {
        if (_pushedButton)
        {
            if (Input.GetKey(KeyCode.W))
            {
                _target.transform.Translate(0f, 0.05f, 0f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                _target.transform.Translate(0f, -0.05f, 0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                _target.transform.Translate(-0.05f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                _target.transform.Translate(0.05f, 0f, 0f);
            }
        }
    }
}
