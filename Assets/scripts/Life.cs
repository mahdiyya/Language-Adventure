using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public int life ;
    public Text lifeText;
    // Use this for initialization
    void Start()
    {
        life = PlayerPrefs.GetInt("playerlifes");
    }

    // Update is called once per frame
    void Update()
    {
        life = PlayerPrefs.GetInt("playerlifes", 5);
        lifeText.text = life.ToString();
    }
}
