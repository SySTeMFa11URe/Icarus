using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GenerateWorld : MonoBehaviour {
    public GameObject grass;
    public GameObject stone;
    public GameObject tree;
    public GameObject sand;
    public GameObject sandstone1;
    public GameObject sandstone2;
    public GameObject sandstone3;
    private int sandstoneType;
    private int biomeType;
	// Use this for initialization
	void Start () {
        for (int x = 0; x < 2; x++)
        {
            for (int xx = 0; xx < 2; xx++)
            {
                for (int xxx = 0; xxx < 2; xxx++)
                {
                    biomeType = Random.Range(0, 3);
                    for (int i = 0; i < Random.Range(20, 25); i++)
                    {
                        for (int ii = 0; ii < 8; ii++)
                        {
                            for (int iii = 0; iii < Random.Range(20, 25); iii++)
                            {
                                if (ii == 7)
                                {
                                    if (biomeType == 2)
                                    {
                                        Instantiate(sand, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                    }
                                    else
                                    {
                                        Instantiate(grass, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                    }
                                }
                                else
                                {
                                    if (Random.Range(0, 3) != 1)
                                    {
                                        if(biomeType == 2)
                                        {
                                            sandstoneType = Random.Range(1, 4);
                                            if (sandstoneType == 1)
                                            {
                                                Instantiate(sandstone1, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                            }
                                            else if (sandstoneType == 2)
                                            {
                                                Instantiate(sandstone2, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                            }
                                            else if (sandstoneType == 3)
                                            {
                                                Instantiate(sandstone3, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                            }
                                        }
                                        else
                                        {
                                            Instantiate(stone, new Vector3(i + x * 40, ii + xx * 40, iii + xxx * 40), Quaternion.identity);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(biomeType != 2)
                    {
                        for (int y = 0; y < Random.Range(1, 4); y++)
                        {
                            Instantiate(tree, new Vector3(Random.Range(0f, 14f) + x * 40, 7 + xx * 40, Random.Range(0f, 14f) + xxx * 40), Quaternion.identity);
                        }
                    }
                }
            }
        }
        Lightmapping.Bake();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
