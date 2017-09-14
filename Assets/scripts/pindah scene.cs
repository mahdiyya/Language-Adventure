
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pindahscene : MonoBehaviour {

    public static int levelN = 0;
    private Button button { get { return GetComponent<Button>(); } }
    // Use this for initialization
 
	
    void nextLevel()
    {
        levelN++;
        SceneManager.LoadScene(levelN);

    }
	// Update is called once per frame
	void Update () {
        Invoke("nextLevel", 0f);
		
	}

}
