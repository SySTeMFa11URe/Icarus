using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCastle : MonoBehaviour {
    public EvilCastle self;
	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(0, 90, 0));
        self.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
