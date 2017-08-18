using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (!(other.gameObject.CompareTag("IslandGen")))
        {
            other.GetComponent<MeshRenderer>().enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (!(other.gameObject.CompareTag("IslandGen")))
        {
            other.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
