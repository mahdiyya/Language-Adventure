using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
    public AudioSource buttonSound;
    public GameObject PanelBaru;
    public int life;

    public void GantiPanelBaru()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelBaru.SetActive(true);

    }
    public void Oke()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelBaru.SetActive(false);
        PlayerPrefs.DeleteAll();
        life = 5;
        PlayerPrefs.SetInt("playerlifes", life);
        SceneManager.LoadScene(1);
       
    }
    public void Cance()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelBaru.SetActive(false);
    }
}
