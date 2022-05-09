using System.Collections;
using UnityEngine;
using TMPro;

public class CharacterDialogue : MonoBehaviour
{
    private string[] _dialogue = new string[24];
    [SerializeField] private AudioClip[] _dialogueAudioClips;

    private string _blankSpace = " ";

    [SerializeField] private int _currentStringIndex;

    public TextMeshProUGUI _dialogueTextDisplay;

    private WaitForSeconds _textDelayTime = new WaitForSeconds(0.05f);
    private WaitForSeconds _textRemoveDelay = new WaitForSeconds(1f);

    [SerializeField] private AudioSource _audioSource;


    void Start()
    {
         _audioSource = GetComponent<AudioSource>();
        _currentStringIndex = 0;
        StringSentences();
    }

    void StringSentences()
    {
        _dialogue[0] = "Brian: Captain, are you sure that there was no other ships available?";
        _dialogue[1] = "Al: That's what they told me...";
        _dialogue[2] = "Brian: I mean i'm all for slapping on a pair of hot pink pants to hit the town with on a Saturdaz night, but this seems a bit rediculous....";
        _dialogue[3] = "Brian: If there is something out here, whoever or whatever it is, is going to seem me coming from miles away!";
        _dialogue[4] = "Al: That's what they told me sargeant";
        _dialogue[5] = "Group laughter";
        _dialogue[6] = "Al: Alright listen up... we are a few team members short for this mission, they are out with covid";
        _dialogue[7] = "Al: so let's make sure we keep our eyes peeled";
        _dialogue[8] = "Chris: Why are we up here again Captain?";
        _dialogue[9] = "Al: The International Space Station has detected some unusual electromagnetic activity in the area";
        _dialogue[10] = "Al: They also reported witnessing whole clusters of stars disappearing for a short period of time, as if something was in betweem them and us...";
        _dialogue[11] = "Chris: CAPTAIN!!! Did you just see that!?!?!!";
        _dialogue[12] = "Al: Hold onto your hats gentlemen, this could get interesting....";
        _dialogue[13] = "Brian: They seem to be disappearing as we get closer to them";
        _dialogue[14] = "Al: Captian Heck reporting to base";
        _dialogue[15] = "Base: Go ahead Heck";
        _dialogue[16] = "Al: We have witnessed some strange electromagnetic activity up here but it seems to have have completely disappeared. I'm bringing the crew home.";
        _dialogue[17] = "Chris: What a spectacular sight.... I will never get tired of this view";
        _dialogue[18] = "Chris: Base if you can here me, please contact my wife and tell her I am picking up a couple of juicy steaks, a bottle of red wine and I will be home soon!";
        _dialogue[19] = "Chris: Uhhhhhh......Captain.....";
        _dialogue[20] = "Chris: What the $#!&!!";
        _dialogue[21] = "Al: Base if you can see this, I need you to send me a scan of that object IMMEDIATELY!";
        _dialogue[22] = "Base: I am sending it to you now";
        _dialogue[23] = "We are going to need a lot more fire power up here....";
    }

    public void RunDialogue()
    {
        StartCoroutine(ShowDialogueRoutine());
    }


    IEnumerator ShowDialogueRoutine()
    {
        _audioSource.clip = _dialogueAudioClips[_currentStringIndex];
        _audioSource.Play();

        foreach (char letter in _dialogue[_currentStringIndex].ToCharArray())
        {
            _dialogueTextDisplay.text += letter;
            yield return _textDelayTime;
        }

        _currentStringIndex++;

        yield return _textRemoveDelay;
        _dialogueTextDisplay.text = _blankSpace;
    }
}
