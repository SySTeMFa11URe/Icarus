using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRenderDistance : MonoBehaviour {
    public GameObject render;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("renderDistance") == 1)
        {
            render.transform.position = new Vector3(0f, 0f, .47f);
            render.transform.localScale = new Vector3(2.420464f, 36.16388f, 1.191703f);
        }
        else if (PlayerPrefs.GetInt("renderDistance") == 2)
        {
            render.transform.position = new Vector3(0f, 0f, .775f);
            render.transform.localScale = new Vector3(3.621988f, 36.16388f, 2.035221f);
        }
        else if (PlayerPrefs.GetInt("renderDistance") == 3)
        {
            render.transform.position = new Vector3(0f, 0f, 1.687f);
            render.transform.localScale = new Vector3(4.564909f, 40.70266f, 4.548862f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
