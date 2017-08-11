using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class GenerateWorld : MonoBehaviour {
    public GameObject grass;
    public GameObject stone;
    public GameObject tree;
    public GameObject sand;
    public GameObject sandstone1;
    public GameObject sandstone2;
    public GameObject sandstone3;
    public GameObject evilCastle;
    public GameObject cursedGrass;
    public GameObject cursedStone;
    public GameObject homeGrass;
    private int sandstoneType;
    private int biomeType;
    private int biomePOS;
    private int range1;
    private int range2;
	// Use this for initialization
	void Start () {
        for (int x = 0; x < 2; x++)
        {
            for (int xx = 0; xx < 2; xx++)
            {
                for (int xxx = 0; xxx < 2; xxx++)
                {
                    if(x ==0 && xx == 0 && xxx == 0)
                    {
                        biomeType = 10;
                        range1 = 20;
                        range2 = 20;
                    }
                    else
                    {
                        biomeType = Random.Range(1, 4);
                        range1 = Random.Range(20, 25);
                        range2 = Random.Range(20, 25);
                    }
                    
                    biomePOS = 40;
                    for (int i = 0; i < range1; i++)
                    {
                        for (int ii = 0; ii < 8; ii++)
                        {
                            for (int iii = 0; iii < range2; iii++)
                            {
                                if (ii == 7)
                                {
                                    if (biomeType == 2)
                                    {
                                        Instantiate(sand, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else if(biomeType == 1)
                                    {
                                        Instantiate(grass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else if(biomeType == 3)
                                    {
                                        Instantiate(cursedGrass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else if (biomeType == 10)
                                    {
                                        Instantiate(homeGrass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                }
                                else
                                {
                                    if (biomeType != 10)
                                    {
                                        if (Random.Range(0, 3) != 1)
                                        {
                                            if (biomeType == 2)
                                            {
                                                sandstoneType = Random.Range(1, 4);
                                                if (sandstoneType == 1)
                                                {
                                                    Instantiate(sandstone1, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                                }
                                                else if (sandstoneType == 2)
                                                {
                                                    Instantiate(sandstone2, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                                }
                                                else if (sandstoneType == 3)
                                                {
                                                    Instantiate(sandstone3, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                                }
                                            }
                                            else if (biomeType == 1)
                                            {
                                                Instantiate(stone, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                            }
                                            else if (biomeType == 3)
                                            {
                                                Instantiate(cursedStone, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Instantiate(stone, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                }
                            }
                        }
                    }
                    if(biomeType == 1)
                    {
                        for (int y = 0; y < Random.Range(1, 4); y++)
                        {
                            Instantiate(tree, new Vector3(Random.Range(0f, 14f) + x * biomePOS, 7 + xx * biomePOS, Random.Range(0f, 14f) + xxx * biomePOS), Quaternion.identity);
                        }
                    }
                    if (biomeType == 3)
                    {
                        /*
                        if (Random.Range(1, 10) == 5)
                        {
                            Instantiate(evilCastle, new Vector3(10f + x * biomePOS, 9f + xx * biomePOS, 9f + xxx * biomePOS), Quaternion.identity);
                        }
                        */
                    }
                }
            }
        }
        //Lightmapping.Bake();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
