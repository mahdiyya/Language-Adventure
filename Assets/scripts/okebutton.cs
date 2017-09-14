using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class okebutton : MonoBehaviour
{

    public AudioSource buttonSound;
    public GameObject PanelAsal;

    public void GantiPanelBaru()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        SceneManager.LoadScene(5);
    }
}
