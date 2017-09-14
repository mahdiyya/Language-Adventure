
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {
    public Button[] levelButton;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject firstlevel;
    public GameObject secondlevel;
    public GameObject thirdlevel;
    public Text level1;
    public Text level2;
    public Text level3;
    public int levelsatu;
    public int leveldua;
    public int leveltiga;
    public int life1;
    public int life2;
    public int life3;
	// Use this for initialization
	void Start () {
        int levelReached = PlayerPrefs.GetInt("levelReached", 0);
        levelsatu = PlayerPrefs.GetInt("starsatu", 0);
        leveldua = PlayerPrefs.GetInt("stardua", 0);
        leveltiga = PlayerPrefs.GetInt("startiga", 0);
        life1 = PlayerPrefs.GetInt("levelsatu", 0);
        life2 = PlayerPrefs.GetInt("leveldua", 0);
        life3 = PlayerPrefs.GetInt("leveltiga", 0);
        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButton[i].interactable = false;
        }
        level1.text = life1.ToString();
        level2.text = life2.ToString();
        level3.text = life3.ToString();

    }

    // Update is called once per frame
    void Update () {
        int levelReached = PlayerPrefs.GetInt("levelReached", 0);
    }
    public void LevelSatu()
    {
        firstlevel.SetActive(true);
        if (levelsatu == 3)
            star3.SetActive(true);
        else if (levelsatu == 2)
            star2.SetActive(true);
        else
            star1.SetActive(true);
    }
    public void LevelDua()
    {
        firstlevel.SetActive(true);
        if (leveldua == 3)
            star3.SetActive(true);
        else if (leveldua == 2)
            star2.SetActive(true);
        else
            star1.SetActive(true);
    }
    public void LevelTiga()
    {
        firstlevel.SetActive(true);
        if (leveltiga == 3)
            star3.SetActive(true);
        else if (leveltiga == 2)
            star2.SetActive(true);
        else
            star1.SetActive(true);
    }
    public void cancelsatu()
    {
        firstlevel.SetActive(false);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }
    public void canceldua()
    {
        secondlevel.SetActive(true);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }
    public void canceltiga()
    {
        thirdlevel.SetActive(true);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }
} 
