using UnityEngine;
using UnityEngine.SceneManagement;

public class KalahButton : MonoBehaviour
{

    public AudioSource buttonSound;
    public GameObject PanelAsal;

    public void GantiPanelBaru()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        SceneManager.LoadScene(0);
    }
}