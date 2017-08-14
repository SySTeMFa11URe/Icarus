using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    public Button yourButton;
	// Use this for initialization
	void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        if(PlayerPrefs.GetInt("crosshairColor", 0) == 0)
        {
            PlayerPrefs.SetInt("crosshairColor", 1);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("renderDistance", 0) == 0)
        {
            PlayerPrefs.SetInt("renderDistance", 1);
            PlayerPrefs.Save();
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnClick()
    {
        SceneManager.LoadScene("main");
    }
}
