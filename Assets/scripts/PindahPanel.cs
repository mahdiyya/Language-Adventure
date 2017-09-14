using UnityEngine;

public class PindahPanel : MonoBehaviour {
    public AudioSource buttonSound;
    public GameObject PanelAsal;
    public GameObject PanelTujuan;

	public void GantiPanelBaru () {
        buttonSound.PlayOneShot(buttonSound.clip);
        PanelAsal.SetActive(false);
        PanelTujuan.SetActive(true);
	}
}
