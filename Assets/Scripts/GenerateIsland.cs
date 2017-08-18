using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIsland : MonoBehaviour {
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
    public GameObject selfScript;
    public GameObject islandGen;
    private int biomePOS = 40;
    private int biomeType;
    private int range1;
    private int range2;
    private int sandstoneType;
    private float xx;
    private float xxx;
    //( ͡° ͜ʖ ͡°)
    // Use this for initialization
    void Start () {
        xx = transform.position.y;
        xxx = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Render"))
        {
            Debug.Log("Island Generation Started");
            biomeType = Random.Range(1, 20);
            range1 = Random.Range(20, 25);
            range2 = Random.Range(20, 25);
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
                                Instantiate(grass, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                            }
                            else if (biomeType <= 17)
                            {
                                Instantiate(sand, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                if (Random.Range(1, 15) == 2)
                                {
                                    if (Random.Range(1, 20) == 5)
                                    {
                                        Instantiate(materialIron, new Vector3(Random.Range(0, 20) + transform.position.x , Random.Range(.2f, .5f) + ii + xx , Random.Range(0, 20) + xxx ), Quaternion.identity);
                                    }
                                    else
                                    {
                                        Instantiate(materialSand, new Vector3(Random.Range(0, 20) + transform.position.x , Random.Range(.2f, .5f) + ii + xx , Random.Range(0, 20) + xxx ), Quaternion.identity);
                                    }
                                }
                            }
                            else if (biomeType == 21)
                            {
                                Instantiate(homeGrass, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                            }
                            else
                            {
                                Instantiate(cursedGrass, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
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
                                        Instantiate(stone, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                    }
                                    else if (biomeType <= 17)
                                    {
                                        sandstoneType = Random.Range(1, 4);
                                        if (sandstoneType == 1)
                                        {
                                            Instantiate(sandstone1, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                        }
                                        else if (sandstoneType == 2)
                                        {
                                            Instantiate(sandstone2, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                        }
                                        else if (sandstoneType == 3)
                                        {
                                            Instantiate(sandstone3, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                        }
                                    }
                                    else
                                    {
                                        Instantiate(cursedStone, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                                    }
                                }
                            }
                            else
                            {
                                Instantiate(stone, new Vector3(i + transform.position.x , ii + xx , iii + xxx ), Quaternion.identity);
                            }
                        }
                    }
                }
            }
            if (biomeType <= 10)
            {
                for (int y = 0; y < Random.Range(1, 4); y++)
                {
                    Instantiate(tree, new Vector3(Random.Range(0f, 14f) + transform.position.x , 7 + xx , Random.Range(0f, 14f) + xxx ), Quaternion.identity);
                }
            }
            Debug.Log("Island Generation Finished");
            selfScript.SetActive(false);
        }
        
    }
}
