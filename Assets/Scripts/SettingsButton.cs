using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour {
    public Button yourButton;
    public GameObject settingsPanel;
    private bool settingsEnabled = false;
    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
	
	// Update is called once per frame
	void Update () {
        if (settingsEnabled)
        {
            settingsPanel.SetActive(true);
        }
        else
        {
            settingsPanel.SetActive(false);
        }
    }
    void OnClick()
    {
        toggleSettings();
    }
    private void toggleSettings()
    {
        if (settingsEnabled)
        {
            settingsEnabled = false;
        }
        else
        {
            settingsEnabled = true;
        }
    }
}
