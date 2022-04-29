using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimations : MonoBehaviour
{
    private Animator _anim;


    void Start()
    {
        _anim = GetComponent<Animator>();

    }

    public void SlouchToSit()
    {
        _anim.SetBool("SlouchToSit", true);
        Debug.Log("Moving from Slouch to Sit position");
    }
}
