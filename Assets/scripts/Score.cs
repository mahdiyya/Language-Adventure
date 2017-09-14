using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int skor;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        skor = PlayerPrefs.GetInt("playerpoints");
    }
	void Update () {
        skor = PlayerPrefs.GetInt("playerpoints");
        scoreText.text = skor.ToString();
	}
}
