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
    public GameObject materialSand;
    public GameObject materialIron;
    public GameObject genIsland;
    private int sandstoneType;
    private int biomeType;
    private int biomePOS = 40;
    private int range1;
    private int range2;
	// Use this for initialization
	void Start () {
        for (int x = 0; x < 20; x++)
        {
            for (int xx = 0; xx < 20; xx++)
            {
                for (int xxx = 0; xxx < 20; xxx++)
                {
                    if (x == 0 && xx == 0 && xxx == 0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int ii = 0; ii < 8; ii++)
                            {
                                for (int iii = 0; iii < 20; iii++)
                                {
                                    if (ii == 7)
                                    {
                                        Instantiate(homeGrass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else
                                    {
                                        Instantiate(stone, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                }
                                }
                            }
                        }
                    else
                    {
                        Instantiate(genIsland, new Vector3(x * biomePOS, xx * biomePOS, xxx * biomePOS), Quaternion.identity);
                    }

                    /*
                    if(x ==0 && xx == 0 && xxx == 0)
                    {
                        biomeType = 21;
                        range1 = 20;
                        range2 = 20;
                    }
                    else
                    {
                        biomeType = Random.Range(1, 20);
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
                                    if (biomeType <= 10)
                                    {
                                        Instantiate(grass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else if(biomeType <= 17)
                                    {
                                        Instantiate(sand, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                        if (Random.Range(1, 15) == 2)
                                        {
                                            if (Random.Range(1, 20) == 5)
                                            {
                                                Instantiate(materialIron, new Vector3(Random.Range(0, 20) + x * biomePOS, Random.Range(.2f, .5f) + ii + xx * biomePOS, Random.Range(0, 20) + xxx * biomePOS), Quaternion.identity);
                                            }
                                            else
                                            {
                                                Instantiate(materialSand, new Vector3(Random.Range(0, 20) + x * biomePOS, Random.Range(.2f, .5f) + ii + xx * biomePOS, Random.Range(0, 20) + xxx * biomePOS), Quaternion.identity);
                                            }
                                        }
                                    }
                                    else if (biomeType == 21)
                                    {
                                        Instantiate(homeGrass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                    else
                                    {
                                        Instantiate(cursedGrass, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                    }
                                }
                                else
                                {
                                    if (biomeType != 21)
                                    {
                                        if (Random.Range(0, 3) != 1)
                                        {
                                            if (biomeType <= 10 || biomeType == 21)
                                            {
                                                Instantiate(stone, new Vector3(i + x * biomePOS, ii + xx * biomePOS, iii + xxx * biomePOS), Quaternion.identity);
                                            }
                                            else if (biomeType <= 17)
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
                                            else
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
                    if(biomeType <= 10)
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
                    //}
                }
            }
        }
        //Lightmapping.Bake();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
