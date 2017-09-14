using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {
    private GameObject[] characterList;
    private int index;
    private int levelReached;
    
	private void Start () {
        index = PlayerPrefs.GetInt("characterSelected");
        levelReached = PlayerPrefs.GetInt("levelReached", 0);
        characterList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in characterList)
            go.SetActive(false);
  
        if (characterList[index])
            characterList[index].SetActive(true);

        
	}
	public void ToggleLeft()
    {
        characterList[index].SetActive(false);

        index--;
        if (index < 0)
            index = characterList.Length - 1;

        characterList[index].SetActive(true);

    }
    public void ToggleRight()
    {
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true);

    }
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("characterSelected", index);
        if (levelReached < 1)
            SceneManager.LoadScene(2);
        else if (levelReached == 1)
            SceneManager.LoadScene(3);
        else
            SceneManager.LoadScene(4);
    }

}
