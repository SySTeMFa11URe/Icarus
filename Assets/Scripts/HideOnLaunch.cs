using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnLaunch : MonoBehaviour {
    // Use this for initialization
    public HideOnLaunch launch;
	void Start () {
        GetComponent<MeshRenderer>().enabled = false;
        launch.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

	}
}
