using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialGame : MonoBehaviour {

    public static AudioSource MainSound;
    public static GameObject MainPanel;
    public static GameObject GuidancePanel;
    public static GameObject SettingPanel;
    public static GameObject VocabPanel;

    public AudioSource mainSound;
    public GameObject mainPanel;
    public GameObject guidancePanel;
    public GameObject settingPanel;
    public GameObject vocabPanel;

    // Use this for initialization
    void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        MainSound = mainSound;
        MainPanel = mainPanel;
        GuidancePanel = guidancePanel;
        SettingPanel = settingPanel;
        VocabPanel = vocabPanel;
		
	}
	
	
}
