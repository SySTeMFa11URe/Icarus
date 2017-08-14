using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorButtonScript : MonoBehaviour {
    public int color;
    public Button yourButton;
    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnClick()
    {
        if(color == 1)
        {
            PlayerPrefs.SetInt("crosshairColor", 1);
        }
        else if (color == 2)
        {
            PlayerPrefs.SetInt("crosshairColor", 2);
        }
        else if (color == 3)
        {
            PlayerPrefs.SetInt("crosshairColor", 3);
        }
        else if (color == 4)
        {
            PlayerPrefs.Save();
            SceneManager.LoadScene("menu");
        }
        else if (color == 5)
        {
            PlayerPrefs.SetInt("renderDistance", 1);
        }
        else if (color == 6)
        {
            PlayerPrefs.SetInt("renderDistance", 2);
        }
        else if (color == 7)
        {
            PlayerPrefs.SetInt("renderDistance", 3);
        }
    }
}
