
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagement : MonoBehaviour {
    public AudioSource buttonSound;
    public void playScene()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        SceneManager.LoadScene(1);
    }
}
