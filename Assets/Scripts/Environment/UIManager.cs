using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject creditsUIWindow;

    [SerializeField] private GameObject[] menuButtons;


    public void OpenCreditsUIWindow()
    {
        creditsUIWindow.SetActive(true);

        for (int i = 0; i < menuButtons.Length; i++)
        {
            menuButtons[i].SetActive(false);
        }
    }

    public void CloseCreditsUIWindow()
    {
        creditsUIWindow.SetActive(false);

        for (int i = 0; i < menuButtons.Length; i++)
        {
            menuButtons[i].SetActive(true);
        }
    }
}
