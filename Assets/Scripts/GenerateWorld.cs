using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour {
    public GameObject grass;
    public GameObject stone;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++)
        {
            for (int ii = 0; ii < 10; ii++)
            {
                for (int iii = 0; iii < 10; iii++)
                {
                    if(ii == 9)
                    {
                        Instantiate(grass, new Vector3(i, ii, iii), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(stone, new Vector3(i, ii, iii), Quaternion.identity);
                    }
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
