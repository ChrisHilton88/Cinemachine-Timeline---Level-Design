using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] private AudioClip clickButtonclip;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ClickButton()
    {
        audioSource.clip = clickButtonclip;
        audioSource.Play();
    }
}
