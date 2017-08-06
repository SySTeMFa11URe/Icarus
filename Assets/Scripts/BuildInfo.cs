using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo : MonoBehaviour {
    public Text info;
    public GameObject player;
    private string BuildNumber = "0002";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Backslash N for newline
        info.text = "Icarus Technical Test \nBuild #"+BuildNumber+" \nX:"+player.transform.position.x+" Y:"+player.transform.position.y+" Z:"+player.transform.position.z;
	}
}
