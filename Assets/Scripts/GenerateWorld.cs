using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour {
    public GameObject grass;
    public GameObject stone;
    public GameObject tree;
	// Use this for initialization
	void Start () {
        for (int x = 0; x < 2; x++)
        {
            for (int xx = 0; xx < 2; xx++)
            {
                for (int xxx = 0; xxx < 2; xxx++)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        for (int ii = 0; ii < 8; ii++)
                        {
                            for (int iii = 0; iii < 15; iii++)
                            {
                                if (ii == 7)
                                {
                                    Instantiate(grass, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                }
                                else
                                {
                                    if (Random.Range(0, 3) != 1)
                                    {
                                        Instantiate(stone, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                    }
                                }
                            }
                        }
                    }
                    for(int y = 0; y < Random.Range(0, 4); y++)
                    Instantiate(tree, new Vector3(Random.Range(0f, 14f) + x * 40, 7 + xx * 40, Random.Range(0f, 14f) + xxx * 40), Quaternion.identity);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
