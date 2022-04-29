using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject creditsUIWindow;

    [SerializeField] private GameObject[] menuButtons;

    [SerializeField] private AudioClip backButtonClip;

    private Vector3 playAtClipLocation = new Vector3(0, 1, -10);



    public void OpenCreditsUIWindow()
    {
        creditsUIWindow.SetActive(true);
    }

    public void CloseCreditsUIWindow()
    {
        creditsUIWindow.SetActive(false);
    }

    // Onluy for the Back Button in the Credits screen
    public void PlayBackButtonAudioClip()
    {
        // Sound is much quieter than the other ones, need to find a way to check it is being played properly.
        AudioSource.PlayClipAtPoint(backButtonClip, playAtClipLocation);
        Debug.Log("Playing Audio Source");
    }
}
