using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairColorChanger : MonoBehaviour {
    public Image self;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("crosshairColor") == 1)
        {
            self.color = new Color(255, 0, 0);
        }
        else if (PlayerPrefs.GetInt("crosshairColor") == 2)
        {
            self.color = new Color(0, 255, 0);
        }
        else if (PlayerPrefs.GetInt("crosshairColor") == 3)
        {
            self.color = new Color(0, 0, 255);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
