using UnityEngine;
using UnityEngine.SceneManagement;

public class MenangButton : MonoBehaviour
{

    public AudioSource buttonSound;
    public GameObject PanelAsal;

    public void GantiPanelBaru()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        SceneManager.LoadScene(2);
    }
    public void MenangMisiDua()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        SceneManager.LoadScene(3);
    }
    public void MenangMisiTiga()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        SceneManager.LoadScene(4);
    }
    public void Kalah()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
    }
    public void Level1()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        SceneManager.LoadScene(3);
    }
    public void Level2()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        SceneManager.LoadScene(4);
    }
    public void Level3()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        SceneManager.LoadScene(0);
    }
}
