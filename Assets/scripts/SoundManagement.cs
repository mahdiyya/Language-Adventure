using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour {
    public Toggle toggle;
	// Use this for initialization
	void Awake () {
        toggle.isOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void matiSemua()
    {
        
        if (toggle.isOn == true)
            AudioListener.volume = 0f;

        else
            AudioListener.volume = 1f;
    }
}
