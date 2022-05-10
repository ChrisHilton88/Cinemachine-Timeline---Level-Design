using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTransitions : MonoBehaviour
{
    private Animator _transitionAnim;


    private void Start()
    {
        _transitionAnim = GetComponent<Animator>();
    }

    // Signal to call this method
    public void FadeOut()
    {
        _transitionAnim.SetTrigger("Fade");
        Debug.Log("It made it!");
    }
}
